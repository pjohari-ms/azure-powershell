// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using Microsoft.Azure.Commands.CosmosDB.Helpers;
using Microsoft.Azure.Commands.CosmosDB.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.CosmosDB.Models;

namespace Microsoft.Azure.Commands.CosmosDB
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "CosmosDBSqlFullTextSpec"), OutputType(typeof(PSFullTextSpec))]
    public class NewAzCosmosDBSqlFullTextSpec : AzureCosmosDBCmdletBase
    {
        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextLanguageHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string Language { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextTokenizerHelpMessage)]
        [PSArgumentCompleter(FullTextTokenizerType.Word)]
        [ValidateNotNullOrEmpty]
        public string Tokenizer { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextFilterHelpMessage)]
        [PSArgumentCompleter(FullTextFilterType.Lowercase, FullTextFilterType.Ascii, FullTextFilterType.Stop, FullTextFilterType.Stem)]
        public string[] Filter { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextStopWordListKindHelpMessage)]
        [PSArgumentCompleter(StopWordListKindType.None, StopWordListKindType.Extended, StopWordListKindType.Basic)]
        [ValidateNotNullOrEmpty]
        public string StopWordListKind { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextAddStopWordHelpMessage)]
        public string[] AddStopWord { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextRemoveStopWordHelpMessage)]
        public string[] RemoveStopWord { get; set; }

        public override void ExecuteCmdlet()
        {
            WriteObject(new PSFullTextSpec
            {
                Language = Language,
                Tokenizer = Tokenizer,
                Filters = Filter,
                StopWordListKind = StopWordListKind,
                AddStopWords = AddStopWord,
                RemoveStopWords = RemoveStopWord
            });
        }
    }
}