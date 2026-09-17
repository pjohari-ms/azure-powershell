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

using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.CosmosDB.Helpers;
using Microsoft.Azure.Commands.CosmosDB.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.CosmosDB.Models;

namespace Microsoft.Azure.Commands.CosmosDB
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "CosmosDBSqlFullTextPolicy"), OutputType(typeof(PSSqlFullTextPolicy))]
    public class NewAzCosmosDBSqlFullTextPolicy : AzureCosmosDBCmdletBase
    {
        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextDefaultLanguageHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string DefaultLanguage { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextPackageHelpMessage)]
        [PSArgumentCompleter(FullTextPackageType.Legacy, FullTextPackageType.Standard)]
        [ValidateNotNullOrEmpty]
        public string Package { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextDefaultSpecHelpMessage)]
        [ValidateNotNull]
        public PSFullTextSpec DefaultSpec { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.FullTextPathsHelpMessage)]
        public PSFullTextPath[] FullTextPath { get; set; }

        public override void ExecuteCmdlet()
        {
            PSSqlFullTextPolicy fullTextPolicy = new PSSqlFullTextPolicy
            {
                DefaultLanguage = DefaultLanguage,
                Package = Package,
                DefaultSpec = DefaultSpec
            };

            if (FullTextPath != null)
            {
                fullTextPolicy.FullTextPaths = new List<PSFullTextPath>(FullTextPath);
            }

            WriteObject(fullTextPolicy);
        }
    }
}