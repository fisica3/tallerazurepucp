param storageAccount object
param env string
param keyVaultName string
param location string

resource myStorageAccountResource 'Microsoft.Storage/storageAccounts@2022-05-01' = {
  name: 'stor${storageAccount.name}${env}'
  sku: {
    name: storageAccount.sku.name

  }
  kind: 'StorageV2'
  location: location
  properties: {
    supportsHttpsTrafficOnly: true
    accessTier: 'Cool'
  }
}

module storageConnectionString '../KeyVault/KeyVaultSecret.bicep' = {
  name: storageAccount.name
  params: {
    keyVaultName: keyVaultName
    secretName: storageAccount.name
    secretValue: myStorageAccountResource.listKeys().keys[0].value
  }
}
