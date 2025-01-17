// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class UserAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("password");
            writer.WriteStringValue(Password);
            if (Optional.IsDefined(ElevationLevel))
            {
                writer.WritePropertyName("elevationLevel");
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
            }
            if (Optional.IsDefined(LinuxUserConfiguration))
            {
                writer.WritePropertyName("linuxUserConfiguration");
                writer.WriteObjectValue(LinuxUserConfiguration);
            }
            if (Optional.IsDefined(WindowsUserConfiguration))
            {
                writer.WritePropertyName("windowsUserConfiguration");
                writer.WriteObjectValue(WindowsUserConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static UserAccount DeserializeUserAccount(JsonElement element)
        {
            string name = default;
            string password = default;
            Optional<ElevationLevel> elevationLevel = default;
            Optional<LinuxUserConfiguration> linuxUserConfiguration = default;
            Optional<WindowsUserConfiguration> windowsUserConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elevationLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToElevationLevel();
                    continue;
                }
                if (property.NameEquals("linuxUserConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxUserConfiguration = LinuxUserConfiguration.DeserializeLinuxUserConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("windowsUserConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsUserConfiguration = WindowsUserConfiguration.DeserializeWindowsUserConfiguration(property.Value);
                    continue;
                }
            }
            return new UserAccount(name, password, Optional.ToNullable(elevationLevel), linuxUserConfiguration.Value, windowsUserConfiguration.Value);
        }
    }
}
