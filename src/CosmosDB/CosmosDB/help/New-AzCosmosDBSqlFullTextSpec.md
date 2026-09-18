---
external help file: Microsoft.Azure.PowerShell.Cmdlets.CosmosDB.dll-Help.xml
Module Name: Az.CosmosDB
online version: https://learn.microsoft.com/powershell/module/az.cosmosdb/new-azcosmosdbsqlfulltextspec
schema: 2.0.0
---

# New-AzCosmosDBSqlFullTextSpec

## SYNOPSIS
Creates a reusable full-text analysis specification.

## SYNTAX

```
New-AzCosmosDBSqlFullTextSpec [-Language <String>] [-Tokenizer <String>] [-Filter <String[]>]
 [-StopWordListKind <String>] [-AddStopWord <String[]>] [-RemoveStopWord <String[]>]
 [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

## DESCRIPTION
Creates a default full-text analysis specification for use with `New-AzCosmosDBSqlFullTextPolicy`.

## EXAMPLES

### Example 1: Create a default full-text specification
```powershell
New-AzCosmosDBSqlFullTextSpec -Language "en-US" -Tokenizer "word" -Filter "lowercase","stop" -StopWordListKind "basic"
```

## PARAMETERS

### -AddStopWord
Custom words to add to the stop-word list.

```yaml
Type: System.String[]
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

### -Filter
The filter pipeline of the full-text analysis. Supported values include Lowercase, Ascii, Stop, and Stem.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:
Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Language
The language of the full-text analysis.

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

### -RemoveStopWord
Words to remove from the built-in stop-word list.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:
Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StopWordListKind
The built-in stop-word list used by the full-text analysis. Supported values are None, Basic, and Extended.

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

### -Tokenizer
The tokenizer method of the full-text analysis. The supported value is Word.

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

### Microsoft.Azure.Commands.CosmosDB.Models.PSFullTextSpec

## NOTES

## RELATED LINKS