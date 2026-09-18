---
external help file: Microsoft.Azure.PowerShell.Cmdlets.CosmosDB.dll-Help.xml
Module Name: Az.CosmosDB
online version: https://learn.microsoft.com/powershell/module/az.cosmosdb/new-azcosmosdbsqlfulltextpolicy
schema: 2.0.0
---

# New-AzCosmosDBSqlFullTextPolicy

## SYNOPSIS
Creates a full-text policy for a Cosmos DB SQL container.

## SYNTAX

```
New-AzCosmosDBSqlFullTextPolicy [-DefaultLanguage <String>] [-Package <String>]
 [-DefaultSpec <PSFullTextSpec>] [-FullTextPath <PSFullTextPath[]>]
 [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

## DESCRIPTION
Creates a full-text policy object that can be supplied to SQL container create and update commands.

## EXAMPLES

### Example 1: Create a customized full-text policy
```powershell
$defaultSpec = New-AzCosmosDBSqlFullTextSpec -Language "en-US" -Tokenizer "word" -Filter "lowercase","stop"
$path = New-AzCosmosDBSqlFullTextPath -Path "/description" -Tokenizer "word" -StopWordListKind "basic"
New-AzCosmosDBSqlFullTextPolicy -DefaultLanguage "en-US" -Package "standard" -DefaultSpec $defaultSpec -FullTextPath $path
```

## PARAMETERS

### -DefaultLanguage
The default language inherited by full-text paths.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:
Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -DefaultSpec
The default full-text analysis specification inherited by full-text paths.

```yaml
Type: Microsoft.Azure.Commands.CosmosDB.Models.PSFullTextSpec
Parameter Sets: (All)
Aliases:
Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FullTextPath
The list of full-text paths.

```yaml
Type: Microsoft.Azure.Commands.CosmosDB.Models.PSFullTextPath[]
Parameter Sets: (All)
Aliases:
Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Package
The full-text package type. Supported values are Legacy and Standard.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:
Required: False
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

### Microsoft.Azure.Commands.CosmosDB.Models.PSSqlFullTextPolicy

## NOTES

## RELATED LINKS