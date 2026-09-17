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
    public class PSFullTextSpec
    {
        public PSFullTextSpec()
        {
        }

        public PSFullTextSpec(FullTextSpec fullTextSpec)
        {
            if (fullTextSpec == null)
            {
                return;
            }

            Language = fullTextSpec.Language;
            Tokenizer = fullTextSpec.Tokenizer;
            Filters = fullTextSpec.Filters;
            StopWordListKind = fullTextSpec.StopWordListKind;
            AddStopWords = fullTextSpec.AddStopWords;
            RemoveStopWords = fullTextSpec.RemoveStopWords;
        }

        public string Language { get; set; }

        public string Tokenizer { get; set; }

        public IList<string> Filters { get; set; }

        public string StopWordListKind { get; set; }

        public IList<string> AddStopWords { get; set; }

        public IList<string> RemoveStopWords { get; set; }

        public static FullTextSpec ToSDKModel(PSFullTextSpec fullTextSpec)
        {
            if (fullTextSpec == null)
            {
                return null;
            }

            return new FullTextSpec
            {
                Language = fullTextSpec.Language,
                Tokenizer = fullTextSpec.Tokenizer,
                Filters = fullTextSpec.Filters,
                StopWordListKind = fullTextSpec.StopWordListKind,
                AddStopWords = fullTextSpec.AddStopWords,
                RemoveStopWords = fullTextSpec.RemoveStopWords
            };
        }
    }
}