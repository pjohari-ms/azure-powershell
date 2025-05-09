// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.PowerShell;

    /// <summary>Customer creates a contact resource for a spacecraft resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ContactTypeConverter))]
    public partial class Contact
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Contact"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Contact(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("AntennaConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesAntennaConfiguration) content.GetValueForProperty("AntennaConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsPropertiesAntennaConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Profile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Profile = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesContactProfile) content.GetValueForProperty("Profile",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Profile, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsPropertiesContactProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ReservationStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationStartTime = (global::System.DateTime) content.GetValueForProperty("ReservationStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ReservationEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationEndTime = (global::System.DateTime) content.GetValueForProperty("ReservationEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RxStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxStartTime = (global::System.DateTime?) content.GetValueForProperty("RxStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RxEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxEndTime = (global::System.DateTime?) content.GetValueForProperty("RxEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TxStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxStartTime = (global::System.DateTime?) content.GetValueForProperty("TxStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TxEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxEndTime = (global::System.DateTime?) content.GetValueForProperty("TxEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("MaximumElevationDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).MaximumElevationDegree = (float?) content.GetValueForProperty("MaximumElevationDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).MaximumElevationDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("StartAzimuthDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartAzimuthDegree = (float?) content.GetValueForProperty("StartAzimuthDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartAzimuthDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("EndAzimuthDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndAzimuthDegree = (float?) content.GetValueForProperty("EndAzimuthDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndAzimuthDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("GroundStationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).GroundStationName = (string) content.GetValueForProperty("GroundStationName",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).GroundStationName, global::System.Convert.ToString);
            }
            if (content.Contains("StartElevationDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartElevationDegree = (float?) content.GetValueForProperty("StartElevationDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartElevationDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("EndElevationDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndElevationDegree = (float?) content.GetValueForProperty("EndElevationDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndElevationDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("AntennaConfigurationDestinationIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationDestinationIP = (string) content.GetValueForProperty("AntennaConfigurationDestinationIP",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationDestinationIP, global::System.Convert.ToString);
            }
            if (content.Contains("AntennaConfigurationSourceIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationSourceIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("AntennaConfigurationSourceIP",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationSourceIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProfileId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProfileId = (string) content.GetValueForProperty("ProfileId",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProfileId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Contact"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Contact(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("AntennaConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesAntennaConfiguration) content.GetValueForProperty("AntennaConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsPropertiesAntennaConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Profile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Profile = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesContactProfile) content.GetValueForProperty("Profile",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Profile, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsPropertiesContactProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ReservationStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationStartTime = (global::System.DateTime) content.GetValueForProperty("ReservationStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ReservationEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationEndTime = (global::System.DateTime) content.GetValueForProperty("ReservationEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ReservationEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RxStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxStartTime = (global::System.DateTime?) content.GetValueForProperty("RxStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RxEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxEndTime = (global::System.DateTime?) content.GetValueForProperty("RxEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).RxEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TxStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxStartTime = (global::System.DateTime?) content.GetValueForProperty("TxStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TxEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxEndTime = (global::System.DateTime?) content.GetValueForProperty("TxEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).TxEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("MaximumElevationDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).MaximumElevationDegree = (float?) content.GetValueForProperty("MaximumElevationDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).MaximumElevationDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("StartAzimuthDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartAzimuthDegree = (float?) content.GetValueForProperty("StartAzimuthDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartAzimuthDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("EndAzimuthDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndAzimuthDegree = (float?) content.GetValueForProperty("EndAzimuthDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndAzimuthDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("GroundStationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).GroundStationName = (string) content.GetValueForProperty("GroundStationName",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).GroundStationName, global::System.Convert.ToString);
            }
            if (content.Contains("StartElevationDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartElevationDegree = (float?) content.GetValueForProperty("StartElevationDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).StartElevationDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("EndElevationDegree"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndElevationDegree = (float?) content.GetValueForProperty("EndElevationDegree",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).EndElevationDegree, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("AntennaConfigurationDestinationIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationDestinationIP = (string) content.GetValueForProperty("AntennaConfigurationDestinationIP",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationDestinationIP, global::System.Convert.ToString);
            }
            if (content.Contains("AntennaConfigurationSourceIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationSourceIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("AntennaConfigurationSourceIP",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).AntennaConfigurationSourceIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProfileId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProfileId = (string) content.GetValueForProperty("ProfileId",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal)this).ProfileId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Contact"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContact" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContact DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Contact(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Contact"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContact" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContact DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Contact(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Contact" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Contact" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContact FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Customer creates a contact resource for a spacecraft resource.
    [System.ComponentModel.TypeConverter(typeof(ContactTypeConverter))]
    public partial interface IContact

    {

    }
}