module "domains_infrastructure" {
  source                 = "./vendor/modules/aks//domains/infrastructure"
  hosted_zone            = var.hosted_zone
  deploy_default_records = var.deploy_default_records
}
