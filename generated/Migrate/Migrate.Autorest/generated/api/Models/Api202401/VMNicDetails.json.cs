// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Hyper V VM network details.</summary>
    public partial class VMNicDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMNicDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMNicDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMNicDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new VMNicDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMNicDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMNicDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._nicId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._nicId.ToString()) : null, "nicId" ,container.Add );
            AddIf( null != (((object)this._replicaNicId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._replicaNicId.ToString()) : null, "replicaNicId" ,container.Add );
            AddIf( null != (((object)this._sourceNicArmId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._sourceNicArmId.ToString()) : null, "sourceNicArmId" ,container.Add );
            AddIf( null != (((object)this._vMNetworkName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._vMNetworkName.ToString()) : null, "vMNetworkName" ,container.Add );
            AddIf( null != (((object)this._recoveryVMNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryVMNetworkId.ToString()) : null, "recoveryVMNetworkId" ,container.Add );
            if (null != this._iPConfig)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __x in this._iPConfig )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("ipConfigs",__w);
            }
            AddIf( null != (((object)this._selectionType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._selectionType.ToString()) : null, "selectionType" ,container.Add );
            AddIf( null != (((object)this._recoveryNetworkSecurityGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryNetworkSecurityGroupId.ToString()) : null, "recoveryNetworkSecurityGroupId" ,container.Add );
            AddIf( null != this._enableAcceleratedNetworkingOnRecovery ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean((bool)this._enableAcceleratedNetworkingOnRecovery) : null, "enableAcceleratedNetworkingOnRecovery" ,container.Add );
            AddIf( null != (((object)this._tfoVMNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._tfoVMNetworkId.ToString()) : null, "tfoVMNetworkId" ,container.Add );
            AddIf( null != (((object)this._tfoNetworkSecurityGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._tfoNetworkSecurityGroupId.ToString()) : null, "tfoNetworkSecurityGroupId" ,container.Add );
            AddIf( null != this._enableAcceleratedNetworkingOnTfo ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean((bool)this._enableAcceleratedNetworkingOnTfo) : null, "enableAcceleratedNetworkingOnTfo" ,container.Add );
            AddIf( null != (((object)this._recoveryNicName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryNicName.ToString()) : null, "recoveryNicName" ,container.Add );
            AddIf( null != (((object)this._recoveryNicResourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryNicResourceGroupName.ToString()) : null, "recoveryNicResourceGroupName" ,container.Add );
            AddIf( null != this._reuseExistingNic ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean((bool)this._reuseExistingNic) : null, "reuseExistingNic" ,container.Add );
            AddIf( null != (((object)this._tfoRecoveryNicName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._tfoRecoveryNicName.ToString()) : null, "tfoRecoveryNicName" ,container.Add );
            AddIf( null != (((object)this._tfoRecoveryNicResourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._tfoRecoveryNicResourceGroupName.ToString()) : null, "tfoRecoveryNicResourceGroupName" ,container.Add );
            AddIf( null != this._tfoReuseExistingNic ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean((bool)this._tfoReuseExistingNic) : null, "tfoReuseExistingNic" ,container.Add );
            AddIf( null != (((object)this._targetNicName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetNicName.ToString()) : null, "targetNicName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="VMNicDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMNicDetails(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_nicId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("nicId"), out var __jsonNicId) ? (string)__jsonNicId : (string)NicId;}
            {_replicaNicId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("replicaNicId"), out var __jsonReplicaNicId) ? (string)__jsonReplicaNicId : (string)ReplicaNicId;}
            {_sourceNicArmId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("sourceNicArmId"), out var __jsonSourceNicArmId) ? (string)__jsonSourceNicArmId : (string)SourceNicArmId;}
            {_vMNetworkName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("vMNetworkName"), out var __jsonVMNetworkName) ? (string)__jsonVMNetworkName : (string)VMNetworkName;}
            {_recoveryVMNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryVMNetworkId"), out var __jsonRecoveryVMNetworkId) ? (string)__jsonRecoveryVMNetworkId : (string)RecoveryVMNetworkId;}
            {_iPConfig = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("ipConfigs"), out var __jsonIPConfigs) ? If( __jsonIPConfigs as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IIPConfigDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IIPConfigDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IPConfigDetails.FromJson(__u) )) ))() : null : IPConfig;}
            {_selectionType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("selectionType"), out var __jsonSelectionType) ? (string)__jsonSelectionType : (string)SelectionType;}
            {_recoveryNetworkSecurityGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryNetworkSecurityGroupId"), out var __jsonRecoveryNetworkSecurityGroupId) ? (string)__jsonRecoveryNetworkSecurityGroupId : (string)RecoveryNetworkSecurityGroupId;}
            {_enableAcceleratedNetworkingOnRecovery = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean>("enableAcceleratedNetworkingOnRecovery"), out var __jsonEnableAcceleratedNetworkingOnRecovery) ? (bool?)__jsonEnableAcceleratedNetworkingOnRecovery : EnableAcceleratedNetworkingOnRecovery;}
            {_tfoVMNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("tfoVMNetworkId"), out var __jsonTfoVMNetworkId) ? (string)__jsonTfoVMNetworkId : (string)TfoVMNetworkId;}
            {_tfoNetworkSecurityGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("tfoNetworkSecurityGroupId"), out var __jsonTfoNetworkSecurityGroupId) ? (string)__jsonTfoNetworkSecurityGroupId : (string)TfoNetworkSecurityGroupId;}
            {_enableAcceleratedNetworkingOnTfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean>("enableAcceleratedNetworkingOnTfo"), out var __jsonEnableAcceleratedNetworkingOnTfo) ? (bool?)__jsonEnableAcceleratedNetworkingOnTfo : EnableAcceleratedNetworkingOnTfo;}
            {_recoveryNicName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryNicName"), out var __jsonRecoveryNicName) ? (string)__jsonRecoveryNicName : (string)RecoveryNicName;}
            {_recoveryNicResourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryNicResourceGroupName"), out var __jsonRecoveryNicResourceGroupName) ? (string)__jsonRecoveryNicResourceGroupName : (string)RecoveryNicResourceGroupName;}
            {_reuseExistingNic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean>("reuseExistingNic"), out var __jsonReuseExistingNic) ? (bool?)__jsonReuseExistingNic : ReuseExistingNic;}
            {_tfoRecoveryNicName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("tfoRecoveryNicName"), out var __jsonTfoRecoveryNicName) ? (string)__jsonTfoRecoveryNicName : (string)TfoRecoveryNicName;}
            {_tfoRecoveryNicResourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("tfoRecoveryNicResourceGroupName"), out var __jsonTfoRecoveryNicResourceGroupName) ? (string)__jsonTfoRecoveryNicResourceGroupName : (string)TfoRecoveryNicResourceGroupName;}
            {_tfoReuseExistingNic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean>("tfoReuseExistingNic"), out var __jsonTfoReuseExistingNic) ? (bool?)__jsonTfoReuseExistingNic : TfoReuseExistingNic;}
            {_targetNicName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetNicName"), out var __jsonTargetNicName) ? (string)__jsonTargetNicName : (string)TargetNicName;}
            AfterFromJson(json);
        }
    }
}