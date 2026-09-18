---
external help file: Microsoft.Azure.PowerShell.Cmdlets.CosmosDB.dll-Help.xml
Module Name: Az.CosmosDB
online version: https://learn.microsoft.com/powershell/module/az.cosmosdb/new-azcosmosdbsqlembeddingsource
schema: 2.0.0
---

# New-AzCosmosDBSqlEmbeddingSource

## SYNOPSIS
Creates an Integrated Embeddings source configuration for a Cosmos DB SQL container.

## SYNTAX

```
New-AzCosmosDBSqlEmbeddingSource -SourcePath <String[]> -Endpoint <String>
 -DeploymentName <String> -ModelName <String> [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

## DESCRIPTION
Creates an embedding source object for use with `New-AzCosmosDBSqlVectorEmbedding`. Authentication uses Microsoft Entra ID.

## EXAMPLES

### Example 1: Create an Azure OpenAI embedding source
```powershell
New-AzCosmosDBSqlEmbeddingSource -SourcePath "/description","/title" -Endpoint "https://example.openai.azure.com" -DeploymentName "text-embedding-3-small" -ModelName "text-embedding-3-small"
```

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentName
The model deployment name used for generating embeddings.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Endpoint
The endpoint URL of the AI model provider resource.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModelName
The name of the embedding model.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourcePath
The non-empty list of top-level source paths used to generate embeddings.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Commands.CosmosDB.Models.PSEmbeddingSource

## NOTES

## RELATED LINKS