// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ManagedInstanceAdministratorListResult
    {
        internal static ManagedInstanceAdministratorListResult DeserializeManagedInstanceAdministratorListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ManagedInstanceAdministrator>> value = default;
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
                    List<ManagedInstanceAdministrator> array = new List<ManagedInstanceAdministrator>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceAdministrator.DeserializeManagedInstanceAdministrator(item));
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
            return new ManagedInstanceAdministratorListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
