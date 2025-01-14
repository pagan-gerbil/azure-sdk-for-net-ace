// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstancePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedInstanceCreateMode))
            {
                writer.WritePropertyName("managedInstanceCreateMode"u8);
                writer.WriteStringValue(ManagedInstanceCreateMode.Value.ToString());
            }
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin"u8);
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(VCores))
            {
                writer.WritePropertyName("vCores"u8);
                writer.WriteNumberValue(VCores.Value);
            }
            if (Optional.IsDefined(StorageSizeInGB))
            {
                writer.WritePropertyName("storageSizeInGB"u8);
                writer.WriteNumberValue(StorageSizeInGB.Value);
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(DnsZonePartner))
            {
                writer.WritePropertyName("dnsZonePartner"u8);
                writer.WriteStringValue(DnsZonePartner);
            }
            if (Optional.IsDefined(IsPublicDataEndpointEnabled))
            {
                writer.WritePropertyName("publicDataEndpointEnabled"u8);
                writer.WriteBooleanValue(IsPublicDataEndpointEnabled.Value);
            }
            if (Optional.IsDefined(SourceManagedInstanceId))
            {
                writer.WritePropertyName("sourceManagedInstanceId"u8);
                writer.WriteStringValue(SourceManagedInstanceId);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime"u8);
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(ProxyOverride))
            {
                writer.WritePropertyName("proxyOverride"u8);
                writer.WriteStringValue(ProxyOverride.Value.ToString());
            }
            if (Optional.IsDefined(TimezoneId))
            {
                writer.WritePropertyName("timezoneId"u8);
                writer.WriteStringValue(TimezoneId);
            }
            if (Optional.IsDefined(InstancePoolId))
            {
                writer.WritePropertyName("instancePoolId"u8);
                writer.WriteStringValue(InstancePoolId);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId"u8);
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion);
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy"u8);
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId.AbsoluteUri);
            }
            if (Optional.IsDefined(Administrators))
            {
                writer.WritePropertyName("administrators"u8);
                writer.WriteObjectValue(Administrators);
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                writer.WritePropertyName("servicePrincipal"u8);
                writer.WriteObjectValue(ServicePrincipal);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
