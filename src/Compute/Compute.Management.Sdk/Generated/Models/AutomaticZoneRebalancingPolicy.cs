// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration parameters used while performing automatic AZ
    /// balancing.
    /// </summary>
    public partial class AutomaticZoneRebalancingPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AutomaticZoneRebalancingPolicy
        /// class.
        /// </summary>
        public AutomaticZoneRebalancingPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomaticZoneRebalancingPolicy
        /// class.
        /// </summary>
        /// <param name="enabled">Specifies whether Automatic AZ Balancing
        /// should be enabled on the virtual machine scale set. The default
        /// value is false.</param>
        /// <param name="rebalanceStrategy">Type of rebalance strategy that
        /// will be used for rebalancing virtual machines in the scale set
        /// across availability zones. Default and only supported value for now
        /// is Recreate. Possible values include: 'Recreate'</param>
        /// <param name="rebalanceBehavior">Type of rebalance behavior that
        /// will be used for recreating virtual machines in the scale set
        /// across availability zones. Default and only supported value for now
        /// is CreateBeforeDelete. Possible values include:
        /// 'CreateBeforeDelete'</param>
        public AutomaticZoneRebalancingPolicy(bool? enabled = default(bool?), string rebalanceStrategy = default(string), string rebalanceBehavior = default(string))
        {
            Enabled = enabled;
            RebalanceStrategy = rebalanceStrategy;
            RebalanceBehavior = rebalanceBehavior;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether Automatic AZ Balancing should be
        /// enabled on the virtual machine scale set. The default value is
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets type of rebalance strategy that will be used for
        /// rebalancing virtual machines in the scale set across availability
        /// zones. Default and only supported value for now is Recreate.
        /// Possible values include: 'Recreate'
        /// </summary>
        [JsonProperty(PropertyName = "rebalanceStrategy")]
        public string RebalanceStrategy { get; set; }

        /// <summary>
        /// Gets or sets type of rebalance behavior that will be used for
        /// recreating virtual machines in the scale set across availability
        /// zones. Default and only supported value for now is
        /// CreateBeforeDelete. Possible values include: 'CreateBeforeDelete'
        /// </summary>
        [JsonProperty(PropertyName = "rebalanceBehavior")]
        public string RebalanceBehavior { get; set; }

    }
}
