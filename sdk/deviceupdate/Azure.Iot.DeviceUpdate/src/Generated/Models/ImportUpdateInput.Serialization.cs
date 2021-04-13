// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    public partial class ImportUpdateInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("importManifest");
            writer.WriteObjectValue(ImportManifest);
            writer.WritePropertyName("files");
            writer.WriteStartArray();
            foreach (var item in Files)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
