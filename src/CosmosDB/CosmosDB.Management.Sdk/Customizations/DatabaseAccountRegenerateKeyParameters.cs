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

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    /// <summary>
    /// Customizations for the generated <see cref="DatabaseAccountRegenerateKeyParameters"/> model.
    /// Adds the optional SkipAccountKeysLastUsageCheck request-body property which is not yet
    /// part of the checked-in generated SDK. The wire key is intentionally PascalCase
    /// ("SkipAccountKeysLastUsageCheck") to match the resource provider contract.
    /// </summary>
    public partial class DatabaseAccountRegenerateKeyParameters
    {
        /// <summary>
        /// Gets or sets a value indicating whether the account keys last-usage safety
        /// check should be skipped during key regeneration. When true, regeneration is
        /// allowed even if the key being regenerated was used recently. When null, the
        /// property is omitted from the request and the service applies its default
        /// behavior.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SkipAccountKeysLastUsageCheck")]
        public bool? SkipAccountKeysLastUsageCheck { get; set; }
    }
}
