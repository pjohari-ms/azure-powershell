// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>The cpu and memory requirement definition.</summary>
    public partial class ComputeResourceDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComputeResourceDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComputeResourceDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Cpu" /> property.</summary>
        private float _cpu;

        /// <summary>The required CPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public float Cpu { get => this._cpu; set => this._cpu = value; }

        /// <summary>Backing field for <see cref="Memory" /> property.</summary>
        private long _memory;

        /// <summary>The required memory in MB, Container memory will be 110 percentile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public long Memory { get => this._memory; set => this._memory = value; }

        /// <summary>Creates an new <see cref="ComputeResourceDefinition" /> instance.</summary>
        public ComputeResourceDefinition()
        {

        }
    }
    /// The cpu and memory requirement definition.
    public partial interface IComputeResourceDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable
    {
        /// <summary>The required CPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The required CPU.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(float) })]
        float Cpu { get; set; }
        /// <summary>The required memory in MB, Container memory will be 110 percentile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The required memory in MB, Container memory will be 110 percentile",
        SerializedName = @"memory",
        PossibleTypes = new [] { typeof(long) })]
        long Memory { get; set; }

    }
    /// The cpu and memory requirement definition.
    internal partial interface IComputeResourceDefinitionInternal

    {
        /// <summary>The required CPU.</summary>
        float Cpu { get; set; }
        /// <summary>The required memory in MB, Container memory will be 110 percentile</summary>
        long Memory { get; set; }

    }
}