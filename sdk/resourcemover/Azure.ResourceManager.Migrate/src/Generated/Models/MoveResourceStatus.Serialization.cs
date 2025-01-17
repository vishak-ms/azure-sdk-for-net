// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MoveResourceStatus
    {
        internal static MoveResourceStatus DeserializeMoveResourceStatus(JsonElement element)
        {
            Optional<MoveState> moveState = default;
            Optional<JobStatus> jobStatus = default;
            Optional<MoveResourceError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("moveState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    moveState = new MoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobStatus = JobStatus.DeserializeJobStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    errors = MoveResourceError.DeserializeMoveResourceError(property.Value);
                    continue;
                }
            }
            return new MoveResourceStatus(Optional.ToNullable(moveState), jobStatus.Value, errors.Value);
        }
    }
}
