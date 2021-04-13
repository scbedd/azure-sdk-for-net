// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    internal partial class DomainListResult
    {
        internal static DomainListResult DeserializeDomainListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Domain>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Domain> array = new List<Domain>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Domain.DeserializeDomain(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DomainListResult(Optional.ToList(value));
        }
    }
}
