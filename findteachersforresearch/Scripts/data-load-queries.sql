--********************************************************************************************************************
--Load script: This load script is designed to be run on dqt reporting db or similar
--It creates the following temp tables :
--ana_persons (this can be psyeudonimised for non PROD environments)
--ana_qualifications
--ana_employments
--ana_current_itt_trainees
--ana_person_prof_status
--********************************************************************************************************************
--                                               PERSONS
--********************************************************************************************************************
--1. Generate persons, the sql returns records that have at least one NULL trs_tps_end_date. This gives us only working
--persons records. We also only take statecode = 0 (from DQT) that removes soft deleted records and anyone with a 
--prohibition/sanction.
--********************************************************************************************************************

--********************************************************************************************************************
--1. Generate persons, the sql looks for person records that have at least one NULL trs_tps_end_date. This gives us only working
--   persons records. We also only take statecode = 0 (from DQT) that removes soft deleted records.
--********************************************************************************************************************

WITH RankedRecords AS (
    SELECT
        trsp.person_id as PersonId,
        trsp.trn as ReferenceNumber,
        trsp.first_name as FirstName,
        trsp.last_name as LastName,
        trsp.date_of_birth as DateOfBirth,
        trsemp.person_email_address as EmailPersonal,
        NULL as EmailWork,
        trsemp.national_insurance_number as Nino,
        ROW_NUMBER() OVER (
            PARTITION BY trsemp.person_id 
            ORDER BY 
                CASE 
                    WHEN trsemp.end_date IS NULL THEN 1 ELSE 0 
                END, 
                trsemp.end_date DESC, 
                trsemp.start_date DESC
        ) AS row_num
    FROM trs_tps_employments trsemp
             INNER JOIN trs_persons trsp
                        ON trsemp.person_id = trsp.person_id
             INNER JOIN contact c
                        ON trsp.dqt_contact_id = c.id

    WHERE trsp.dqt_state = 0
)
SELECT  --TOP 500 
        FirstName,LastName,Nino,DateOfBirth,ReferenceNumber,EmailWork,EmailPersonal,'false' as OptedOutOfResearch,PersonId
FROM RankedRecords
WHERE row_num = 1
  AND PersonId IN (
    SELECT DISTINCT trsemp.person_id
    FROM trs_tps_employments trsemp
    WHERE trsemp.end_date IS NULL

);
-- IN DEV AND TEST:
-- SAVE REULTS TO input.cs and run /Scripts/Person-data-faker.py
SELECT COUNT(1) FROM ana_persons; ----760,309 @ 27/03/2025

--********************************************************************************************************************
--PROD ENVIRONMENTS ONLY: 
--********************************************************************************************************************
--1.a Alter the above SQL to insert directly into ana_persons

--Now gnerate the other entities using person_id as a foreign key
--********************************************************************************************************************
--                                               EMPLOYMENT
--********************************************************************************************************************
--2 Generate employment records for all persons. There could be multiple depending on if they have changed jobs
--recently and/or work in multiple establishmnets.
--DROP TABLE ana_employment
SELECT
    trsemp.person_id as PersonId, e.establishment_name as EstablishmentName, e.establishment_type_group_name as EstablishmentTypeGroupName,
    trsemp.employer_postcode as EmployerPostcode,trsemp.start_date as StartDate,trsemp.end_date as EndDate,trsemp.last_known_tps_employed_date as LastSeenInTPSDate,
    trsemp.last_extract_date as ExtractDate, trsemp.employment_type as EmploymentType,trsemp.withdrawal_confirmed as WithdrawalConfirmed,e.urn as Urn,
    e.establishment_status_name as EstablishmentStatus, e.establishment_source_id as EstablishmentSource,e.phase_of_education_name as PhaseOfEducation,
    e.number_of_pupils as NumberOfPupils,e.free_school_meals_percentage as FSMPercentage
INTO ana_employment
FROM trs_tps_employments trsemp
         INNER JOIN ana_persons p
                    ON trsemp.person_id = p.PersonId
         INNER JOIN trs_establishments e
                    ON trsemp.establishment_id = e.establishment_id;

SELECT COUNT(1) FROM ana_employment; --825,629 @27/03/2025

-- Model friendly select for loader tool:
--Employment
select PersonId,EstablishmentName,EstablishmentTypeGroupName,StartDate,EndDate,LastSeenInTPSDate,EmploymentType,EstablishmentStatus,EstablishmentSource,
       EmployerPostcode,ExtractDate,FSMPercentage,NumberOfPupils,PhaseOfEducation,Urn,WithdrawalConfirmed
from ana_employment; --825629

--********************************************************************************************************************
--                                               QUALIFICATIONS
--********************************************************************************************************************
--3 Generate 1 row person, showing EYTS, QTS and grouping NPQ's
--DROP TABLE ana_qualifications
SELECT
    p.PersonId AS PersonId,
    c.dfeta_qtsdate AS QTSDate,
    c.dfeta_eytsdate AS EYTSDate,
    SUM(CASE WHEN q.dfeta_mq_date IS NOT NULL THEN 1 ELSE 0 END) AS MQ,
    SUM(CASE WHEN q.dfeta_npqml_date IS NOT NULL THEN 1 ELSE 0 END) AS NPQML,
    SUM(CASE WHEN q.dfeta_npqltd_date IS NOT NULL THEN 1 ELSE 0 END) AS NPQLTD,
    SUM(CASE WHEN q.dfeta_npqlt_date IS NOT NULL THEN 1 ELSE 0 END) AS NPQLT,
    SUM(CASE WHEN q.dfeta_npqlbc_date IS NOT NULL THEN 1 ELSE 0 END) AS NPQLBC,
    SUM(CASE WHEN q.dfeta_npqsl_date IS NOT NULL THEN 1 ELSE 0 END) AS NPQSL,
    SUM(CASE WHEN q.dfeta_npqh_date IS NOT NULL THEN 1 ELSE 0 END) AS NPQH,
    SUM(CASE WHEN q.dfeta_npqel_date IS NOT NULL THEN 1 ELSE 0 END) AS NPQEL
INTO ana_qualifications
FROM ana_persons p
         INNER JOIN contact c
                    ON p.PersonId = c.Id
         LEFT JOIN (
    SELECT
        dfeta_personid,
        dfeta_mq_date,
        dfeta_npqml_date,
        dfeta_npqltd_date,
        dfeta_npqlt_date,
        dfeta_npqlbc_date,
        dfeta_npqsl_date,
        dfeta_npqh_date,
        dfeta_npqel_date
    FROM dfeta_qualification
) q
                   ON p.PersonId = q.dfeta_personid
GROUP BY p.PersonId, c.dfeta_qtsdate, c.dfeta_eytsdate;

--760,309 @ 27/03/2025

--********************************************************************************************************************
--                                               TRAINEES
--********************************************************************************************************************

--4 Generate Trainees working at a school
-- This is also needed to build prof status in a simpler way.
--DROP TABLE ana_trainees_in_schools
SELECT DISTINCT
    c.dfeta_trn,c.id,ts.dfeta_name,qts.dfeta_qtsdate
              ,(SELECT TOP 1 o.LocalizedLabel FROM dbo.[GlobalOptionSetMetadata] o with(NoLock) WHERE o.[OptionSetName] = 'dfeta_programmetype' and o.[Option] = itt.dfeta_programmetype and o.LocalizedLabelLanguageCode = 1033) AS 'programme'
    ,(SELECT TOP 1 r.LocalizedLabel FROM dbo.[GlobalOptionSetMetadata] r with(NoLock) WHERE r.[OptionSetName] = 'dfeta_result' and r.[Option] = itt.dfeta_result and r.LocalizedLabelLanguageCode = 1033) AS 'result'
    ,a.name AS 'provider',a.dfeta_ukprn,itt.dfeta_programmestartdate AS 'trainingstart',itt.dfeta_programmeenddate AS 'trainingend'
INTO ana_trainees_in_schools
FROM ana_persons p
    INNER JOIN contact c ON p.PersonId = c.id
    INNER JOIN dfeta_initialteachertraining itt ON itt.dfeta_personid = c.id
    LEFT OUTER JOIN account a ON a.id = itt.dfeta_establishmentid
    INNER JOIN dfeta_qtsregistration qts ON qts.dfeta_personid = itt.dfeta_personid
    INNER JOIN dfeta_teacherstatus ts ON ts.dfeta_teacherstatusid = qts.dfeta_teacherstatusid

WHERE c.statecode = 0 AND itt.statecode = 0 AND qts.statecode = 0 AND c.dfeta_trn IS NOT NULL
  AND ts.dfeta_name IN (N'Trainee Teacher')
  AND itt.dfeta_result IN (N'389040003') --In training
  AND ((itt.dfeta_programmetype IS  NULL)
   OR (itt.dfeta_programmetype NOT IN (N'389040014',N'389040016',N'389040015',N'389040018',N'389040017',N'389040010'))) --Exclude Early Years/Assessment only
ORDER BY c.dfeta_trn, itt.dfeta_programmestartdate DESC;

--3596 @ 27/03/2025

--********************************************************************************************************************
--                                               PROF STATUS
--********************************************************************************************************************
--5 Generate prof status. NB this is a very cut down version of the "professional status" in TRS.
-- a. Qualified Teacher
-- b. Unqualified Teacher
-- c. Trainee Teacher

--DROP TABLE ana_prof_status;

SELECT p.PersonId as PersonId ,
       CASE
           WHEN t.dfeta_name = 'Trainee Teacher' THEN 2
           WHEN q.QTSDate IS NOT NULL THEN 0
           WHEN q.QTSDate IS NULL THEN 1
           ELSE 0
           END AS ProfStatusName
INTO ana_prof_status
FROM ana_persons p
         LEFT OUTER JOIN ana_trainees_in_schools t ON p.PersonId = t.id
         INNER JOIN ana_qualifications q ON p.PersonId = q.personId;

--587,827 Qualified
--3596 Trainees (in work)
--168886 Unqualified
--760309 Total @ 27/03/2025


--********************************************************************************************************************
--PostgreSQL Load commands
--********************************************************************************************************************
--Person
--command " "\\copy public.\"Persons\" (\"FirstName\", \"LastName\", \"Nino\", \"DateOfBirth\", \"ReferenceNumber\", \"EmailWork\", \"EmailPersonal\", \"OptedOutOfResearch\", \"PersonId\") FROM '/Users/aje/dev/python-projects/research/ftr-pp-persons.csv' DELIMITER ',' CSV HEADER ENCODING 'UTF8' QUOTE '\"' NULL 'NULL' ESCAPE '''';""
--ProfStatus
--command " "\\copy public.\"ProfStatus\" (\"PersonId\", \"StatusName\") FROM '/Users/aje/dev/python-projects/research/ftr-pp-prof-status.csv' DELIMITER ',' CSV HEADER ENCODING 'UTF8' QUOTE '\"' NULL 'NULL' ESCAPE '''';""
---Qualification
--command " "\\copy public.\"Qualification\" (\"PersonId\", \"NPQSL\", \"EYTSDate\", \"MQ\", \"NPQEL\", \"NPQH\", \"NPQLBC\", \"NPQLTD\", \"NPQML\", \"QTSDate\") FROM '/Users/aje/dev/python-projects/research/ftr-pp-qualifications.csv' DELIMITER ',' CSV HEADER ENCODING 'UTF8' QUOTE '\"' NULL 'NULL' ESCAPE '''';""
--Employment
--command " "\\copy public.\"Employment\" (\"PersonId\", \"EstablishmentName\", \"EstablishmentTypeGroupName\", \"StartDate\", \"EndDate\", \"LastSeenInTPSDate\", \"EmploymentType\", \"EstablishmentStatus\", \"EstablishmentSource\", \"EmployerPostcode\", \"ExtractDate\", \"FSMPercentage\", \"NumberOfPupils\", \"PhaseOfEducation\", \"Urn\", \"WithdrawalConfirmed\") FROM '/Users/aje/dev/python-projects/research/ftr-pp-employment.csv' DELIMITER ',' CSV HEADER ENCODING 'UTF8' QUOTE '\"' NULL 'NULL' ESCAPE '''';""