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
    public class PSEmbeddingSource
    {
        public PSEmbeddingSource()
        {
        }

        public PSEmbeddingSource(EmbeddingSource embeddingSource)
        {
            if (embeddingSource == null)
            {
                return;
            }

            SourcePaths = embeddingSource.SourcePaths;
            Endpoint = embeddingSource.Endpoint;
            DeploymentName = embeddingSource.DeploymentName;
            ModelName = embeddingSource.ModelName;
            AuthType = EmbeddingSource.AuthType;
        }

        public IList<string> SourcePaths { get; set; }

        public string Endpoint { get; set; }

        public string DeploymentName { get; set; }

        public string ModelName { get; set; }

        public string AuthType { get; set; }

        public static EmbeddingSource ToSDKModel(PSEmbeddingSource embeddingSource)
        {
            if (embeddingSource == null)
            {
                return null;
            }

            return new EmbeddingSource(
                embeddingSource.SourcePaths,
                embeddingSource.Endpoint,
                embeddingSource.DeploymentName,
                embeddingSource.ModelName);
        }
    }
}