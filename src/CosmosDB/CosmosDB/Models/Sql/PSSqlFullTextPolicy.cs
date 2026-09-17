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

using Microsoft.Azure.Management.CosmosDB.Models;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.CosmosDB.Models
{
    public class PSSqlFullTextPolicy
    {
        public PSSqlFullTextPolicy()
        {
        }

        public PSSqlFullTextPolicy(FullTextPolicy fullTextPolicy)
        {
            if (fullTextPolicy == null)
            {
                return;
            }

            DefaultLanguage = fullTextPolicy.DefaultLanguage;
            Package = fullTextPolicy.Package;
            DefaultSpec = fullTextPolicy.DefaultSpec != null
                ? new PSFullTextSpec(fullTextPolicy.DefaultSpec)
                : null;

            if (fullTextPolicy.FullTextPaths != null)
            {
                FullTextPaths = new List<PSFullTextPath>();
                foreach (FullTextPath fullTextPath in fullTextPolicy.FullTextPaths)
                {
                    FullTextPaths.Add(new PSFullTextPath(fullTextPath));
                }
            }
        }

        public string DefaultLanguage { get; set; }

        public string Package { get; set; }

        public PSFullTextSpec DefaultSpec { get; set; }

        public IList<PSFullTextPath> FullTextPaths { get; set; }

        public static FullTextPolicy ToSDKModel(PSSqlFullTextPolicy fullTextPolicy)
        {
            if (fullTextPolicy == null)
            {
                return null;
            }

            FullTextPolicy sdkFullTextPolicy = new FullTextPolicy
            {
                DefaultLanguage = fullTextPolicy.DefaultLanguage,
                Package = fullTextPolicy.Package,
                DefaultSpec = PSFullTextSpec.ToSDKModel(fullTextPolicy.DefaultSpec)
            };

            if (fullTextPolicy.FullTextPaths != null)
            {
                sdkFullTextPolicy.FullTextPaths = new List<FullTextPath>();
                foreach (PSFullTextPath fullTextPath in fullTextPolicy.FullTextPaths)
                {
                    sdkFullTextPolicy.FullTextPaths.Add(PSFullTextPath.ToSDKModel(fullTextPath));
                }
            }

            return sdkFullTextPolicy;
        }
    }
}