// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class ServiceStatistics
    {
        internal static ServiceStatistics DeserializeServiceStatistics(JsonElement element)
        {
            long? connectedDeviceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectedDeviceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedDeviceCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new ServiceStatistics(connectedDeviceCount);
        }
    }
}