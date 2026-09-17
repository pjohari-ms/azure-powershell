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

namespace Microsoft.Azure.Commands.CosmosDB
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "CosmosDBSqlEmbeddingSource"), OutputType(typeof(PSEmbeddingSource))]
    public class NewAzCosmosDBSqlEmbeddingSource : AzureCosmosDBCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = Constants.EmbeddingSourcePathHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string[] SourcePath { get; set; }

        [Parameter(Mandatory = true, HelpMessage = Constants.EmbeddingSourceEndpointHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string Endpoint { get; set; }

        [Parameter(Mandatory = true, HelpMessage = Constants.EmbeddingSourceDeploymentNameHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string DeploymentName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = Constants.EmbeddingSourceModelNameHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string ModelName { get; set; }

        public override void ExecuteCmdlet()
        {
            PSEmbeddingSource embeddingSource = new PSEmbeddingSource
            {
                SourcePaths = SourcePath,
                Endpoint = Endpoint,
                DeploymentName = DeploymentName,
                ModelName = ModelName,
                AuthType = "Entra"
            };

            WriteObject(embeddingSource);
        }
    }
}