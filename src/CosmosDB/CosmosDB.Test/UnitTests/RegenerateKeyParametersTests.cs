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

using Microsoft.Azure.Management.CosmosDB;
using Microsoft.Azure.Management.CosmosDB.Models;
using Microsoft.Rest;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Newtonsoft.Json;
using Xunit;

namespace Microsoft.Azure.Commands.CosmosDB.Test.UnitTests
{
    /// <summary>
    /// Offline unit tests that validate the request body produced for the
    /// <c>-SkipSafeRotation</c> switch on <c>New-AzCosmosDBAccountKey</c>.
    /// They serialize <see cref="DatabaseAccountRegenerateKeyParameters"/> using the
    /// same serialization settings the management client uses on the wire, asserting
    /// that the property is sent only when the switch is present (mapped to true) and
    /// omitted otherwise.
    /// </summary>
    public class RegenerateKeyParametersTests
    {
        private static string SerializeWithClientSettings(DatabaseAccountRegenerateKeyParameters parameters)
        {
            using (var client = new CosmosDBManagementClient(new TokenCredentials("fake-token")))
            {
                return JsonConvert.SerializeObject(parameters, client.SerializationSettings);
            }
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void SkipSafeRotationPresent_SendsSkipAccountKeysLastUsageCheckTrue()
        {
            // Mirrors the cmdlet mapping when -SkipSafeRotation is supplied:
            // SkipSafeRotation.IsPresent ? (bool?)true : null
            var parameters = new DatabaseAccountRegenerateKeyParameters
            {
                KeyKind = "primary",
                SkipAccountKeysLastUsageCheck = true
            };

            string json = SerializeWithClientSettings(parameters);

            // PascalCase wire key must match the backend RP contract exactly.
            Assert.Contains("\"SkipAccountKeysLastUsageCheck\": true", json);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void SkipSafeRotationAbsent_OmitsSkipAccountKeysLastUsageCheck()
        {
            // Mirrors the cmdlet mapping when -SkipSafeRotation is NOT supplied
            // (the property is left null and must not appear on the wire).
            var parameters = new DatabaseAccountRegenerateKeyParameters
            {
                KeyKind = "primary",
                SkipAccountKeysLastUsageCheck = null
            };

            string json = SerializeWithClientSettings(parameters);

            Assert.DoesNotContain("SkipAccountKeysLastUsageCheck", json);
        }
    }
}
