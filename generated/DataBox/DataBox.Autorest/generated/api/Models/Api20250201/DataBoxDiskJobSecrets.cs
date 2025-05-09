// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The secrets related to disk job.</summary>
    public partial class DataBoxDiskJobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskJobSecrets,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskJobSecretsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets __jobSecrets = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets();

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).AdditionalInfo; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Code = value ?? null; }

        /// <summary>Dc Access Security Code for Customer Managed Shipping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode DcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode; }

        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeForwardDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeForwardDcAccessCode = value ?? null; }

        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeReverseDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeReverseDcAccessCode = value ?? null; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Detail; }

        /// <summary>Backing field for <see cref="DiskSecret" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDiskSecret[] _diskSecret;

        /// <summary>Contains the list of secrets object for that device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDiskSecret[] DiskSecret { get => this._diskSecret; }

        /// <summary>Error while fetching the secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Error; }

        /// <summary>Backing field for <see cref="IsPasskeyUserDefined" /> property.</summary>
        private bool? _isPasskeyUserDefined;

        /// <summary>Whether passkey was provided by user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public bool? IsPasskeyUserDefined { get => this._isPasskeyUserDefined; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Message = value ?? null; }

        /// <summary>Internal Acessors for DiskSecret</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDiskSecret[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskJobSecretsInternal.DiskSecret { get => this._diskSecret; set { {_diskSecret = value;} } }

        /// <summary>Internal Acessors for IsPasskeyUserDefined</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskJobSecretsInternal.IsPasskeyUserDefined { get => this._isPasskeyUserDefined; set { {_isPasskeyUserDefined = value;} } }

        /// <summary>Internal Acessors for PassKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskJobSecretsInternal.PassKey { get => this._passKey; set { {_passKey = value;} } }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).AdditionalInfo = value; }

        /// <summary>Internal Acessors for DcAccessSecurityCode</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.DcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Error = value; }

        /// <summary>Backing field for <see cref="PassKey" /> property.</summary>
        private string _passKey;

        /// <summary>PassKey for the disk Job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string PassKey { get => this._passKey; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Target = value ?? null; }

        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Type = value ; }

        /// <summary>Creates an new <see cref="DataBoxDiskJobSecrets" /> instance.</summary>
        public DataBoxDiskJobSecrets()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobSecrets), __jobSecrets);
            await eventListener.AssertObjectIsValid(nameof(__jobSecrets), __jobSecrets);
        }
    }
    /// The secrets related to disk job.
    public partial interface IDataBoxDiskJobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets
    {
        /// <summary>Contains the list of secrets object for that device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Contains the list of secrets object for that device.",
        SerializedName = @"diskSecrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDiskSecret) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDiskSecret[] DiskSecret { get;  }
        /// <summary>Whether passkey was provided by user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Whether passkey was provided by user.",
        SerializedName = @"isPasskeyUserDefined",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPasskeyUserDefined { get;  }
        /// <summary>PassKey for the disk Job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"PassKey for the disk Job.",
        SerializedName = @"passKey",
        PossibleTypes = new [] { typeof(string) })]
        string PassKey { get;  }

    }
    /// The secrets related to disk job.
    internal partial interface IDataBoxDiskJobSecretsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal
    {
        /// <summary>Contains the list of secrets object for that device.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDiskSecret[] DiskSecret { get; set; }
        /// <summary>Whether passkey was provided by user.</summary>
        bool? IsPasskeyUserDefined { get; set; }
        /// <summary>PassKey for the disk Job.</summary>
        string PassKey { get; set; }

    }
}