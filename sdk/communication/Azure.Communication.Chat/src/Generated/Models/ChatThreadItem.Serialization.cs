// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    public partial class ChatThreadItem
    {
        internal static ChatThreadItem DeserializeChatThreadItem(JsonElement element)
        {
            string id = default;
            string topic = default;
            Optional<DateTimeOffset> deletedOn = default;
            Optional<DateTimeOffset> lastMessageReceivedOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"))
                {
                    topic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deletedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastMessageReceivedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastMessageReceivedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ChatThreadItem(id, topic, Optional.ToNullable(deletedOn), Optional.ToNullable(lastMessageReceivedOn));
        }
    }
}
