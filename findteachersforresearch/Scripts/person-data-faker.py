import csv
from faker import Faker

fake = Faker()

input_file = "input.csv" 
output_file = "output.csv" 

def anonymize_csv(input_file, output_file):
    try:
        
        with open(input_file, mode='r', newline='', encoding='utf-8') as infile, \
                open(output_file, mode='w', newline='', encoding='utf-8') as outfile:

            reader = csv.DictReader(infile)
            fieldnames = reader.fieldnames
            writer = csv.DictWriter(outfile, fieldnames=fieldnames)

            writer.writeheader()

            for row in reader:
                row['FirstName'] = fake.first_name()
                row['LastName'] = fake.last_name()
                row['Nino'] = fake.random_number(digits=9, fix_len=True) 
                row['DateOfBirth']
                row['ReferenceNumber'] = fake.random_number(digits=7, fix_len=True)
                row['EmailWork'] = fake.email()
                row['EmailPersonal'] = fake.email()
                row['OptedOutOfResearch'] = 'false'
                row['PersonId']
                writer.writerow(row)

        print(f"Anonymized data has been written to {output_file}")

    except FileNotFoundError:
        print(f"Error: {input_file} not found!")
    except Exception as e:
        print(f"An error occurred: {e}")

if __name__ == "__main__":
    anonymize_csv(input_file, output_file)
