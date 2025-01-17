// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleEligibilityScheduleRequestPropertiesScheduleInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(Expiration))
            {
                writer.WritePropertyName("expiration");
                writer.WriteObjectValue(Expiration);
            }
            writer.WriteEndObject();
        }

        internal static RoleEligibilityScheduleRequestPropertiesScheduleInfo DeserializeRoleEligibilityScheduleRequestPropertiesScheduleInfo(JsonElement element)
        {
            Optional<DateTimeOffset> startDateTime = default;
            Optional<RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration> expiration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiration = RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration.DeserializeRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration(property.Value);
                    continue;
                }
            }
            return new RoleEligibilityScheduleRequestPropertiesScheduleInfo(Optional.ToNullable(startDateTime), expiration.Value);
        }
    }
}
