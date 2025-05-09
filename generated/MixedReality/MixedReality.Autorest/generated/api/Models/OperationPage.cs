// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list Resource Provider operations. It contains a list of operations and a URL link to get the
    /// next set of results.
    /// </summary>
    public partial class OperationPage :
        Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IOperationPage,
        Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IOperationPageInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Origin(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IOperation> _value;

        /// <summary>List of operations supported by the Resource Provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Origin(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IOperation> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationPage" /> instance.</summary>
        public OperationPage()
        {

        }
    }
    /// Result of the request to list Resource Provider operations. It contains a list of operations and a URL link to get the
    /// next set of results.
    public partial interface IOperationPage :
        Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URL to get the next set of operation list results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of operations supported by the Resource Provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of operations supported by the Resource Provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IOperation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IOperation> Value { get; set; }

    }
    /// Result of the request to list Resource Provider operations. It contains a list of operations and a URL link to get the
    /// next set of results.
    internal partial interface IOperationPageInternal

    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>List of operations supported by the Resource Provider.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IOperation> Value { get; set; }

    }
}