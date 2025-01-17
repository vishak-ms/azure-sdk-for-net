// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class SnapshotListResult
    {
        internal static SnapshotListResult DeserializeSnapshotListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SnapshotData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SnapshotData> array = new List<SnapshotData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SnapshotData.DeserializeSnapshotData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SnapshotListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
