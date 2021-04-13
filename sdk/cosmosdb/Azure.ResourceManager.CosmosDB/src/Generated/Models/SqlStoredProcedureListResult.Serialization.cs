// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class SqlStoredProcedureListResult
    {
        internal static SqlStoredProcedureListResult DeserializeSqlStoredProcedureListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SqlStoredProcedureGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SqlStoredProcedureGetResults> array = new List<SqlStoredProcedureGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlStoredProcedureGetResults.DeserializeSqlStoredProcedureGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SqlStoredProcedureListResult(Optional.ToList(value));
        }
    }
}
