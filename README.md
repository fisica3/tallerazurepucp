# Taller Azure PUCP
Repositorio para compartir material en el Taller de Azure en la PUCP (17/2/2023)

Recordar ir a https://aka.ms/JoinEduLab para iniciar el proceso de creación de una cuenta Microsoft 

## Enlaces rapidos

- [Definición del NIST](https://csrc.nist.gov/publications/detail/sp/800-145/final)
- [¿Qué es PaaS?](https://azure.microsoft.com/es-es/overview/what-is-paas/?WT.mc_id=AZ-MVP-5002314)
- [Microsoft Azure Global infrastructure](https://infrastructuremap.microsoft.com/)
- [Azure products](https://azure.microsoft.com/en-us/products/?WT.mc_id=AZ-MVP-5002314)
- [AzureCharts.com](https://azurecharts.com) by Alexey Polkovnikov 

- [Exercise - Explore the Learn sandbox](https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/4-exercise-explore-learn-sandbox)
- [Azure Storage Explorer](https://azure.microsoft.com/en-us/products/storage/storage-explorer/?WT.mc_id=AZ-MVP-5002314)
- Blob Containers: imagecontainer  Blob, imageoutputcontainer Container

- az group create --location eastus2 --resource-group rgdemovmpucp01

- [Exercise - Create an Azure Virtual Machine](https://docs.microsoft.com/learn/modules/describe-azure-compute-networking-services/3-exercise-create-azure-virtual-machine)
- [Exercise - Configure network access](https://docs.microsoft.com/learn/modules/describe-azure-compute-networking-services/9-exercise-configure-network-access/)

- Application Setting: azureactionern_STORAGE
AZURE_FUNCTIONAPP_PACKAGE_PATH: './sampleResizer' # set this to the path to your web app project, defaults to the repository root

## Deploy via Bicep
Despleguemos este ejemplo usando el Azure CLI.

1. Clone este repo y vaya al folder /sampleBicep/Composing/
2. Ejecute los siguientes comandos CLI (colocando el nombre adecuado para el Grupo de Recursos)
  ```cli
  az group create --location westeurope --resource-group __myrgname__
  az deployment group create --resource-group __myrgname__ --template-file Main.bicep --parameters Main.parameters.test.json
```

## Material suplementario:

- [Microsoft Learn Path for Azure Fundamentals](https://learn.microsoft.com/en-us/certifications/azure-fundamentals/?WT.mc_id=AZ-MVP-5002314)
- [Directory of Azure Services by Technical Category](https://azure.microsoft.com/en-us/products/?WT.mc_id=AZ-MVP-5002314)
- [List of Azure Services for Developers to Know](https://learn.microsoft.com/en-us/azure/developer/intro/azure-developer-key-services?source=recommendations)
- [Learn Azure in a Month of Lunches, Second Edition](https://azure.microsoft.com/en-us/resources/learn-azure-in-a-month-of-lunches/?WT.mc_id=AZ-MVP-5002314) 

- [Azure Fridays](https://learn.microsoft.com/en-us/shows/azure-friday/?WT.mc_id=AZ-MVP-5002314)
- [Microsoft Virtual Training Days](https://www.microsoft.com/en-us/trainingdays)
- [Technical Resources for Academic Communities - Curricula](https://github.com/microsoft/AcademicContent/blob/main/curricula.md)
- [Microsoft Learn Educator Center](https://learn.microsoft.com/en-us/training/educator-center/?WT.mc_id=AZ-MVP-5002314)
