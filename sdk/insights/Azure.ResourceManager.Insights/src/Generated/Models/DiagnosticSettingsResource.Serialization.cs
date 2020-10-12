// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class DiagnosticSettingsResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId");
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(ServiceBusRuleId))
            {
                writer.WritePropertyName("serviceBusRuleId");
                writer.WriteStringValue(ServiceBusRuleId);
            }
            if (Optional.IsDefined(EventHubAuthorizationRuleId))
            {
                writer.WritePropertyName("eventHubAuthorizationRuleId");
                writer.WriteStringValue(EventHubAuthorizationRuleId);
            }
            if (Optional.IsDefined(EventHubName))
            {
                writer.WritePropertyName("eventHubName");
                writer.WriteStringValue(EventHubName);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics");
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Logs))
            {
                writer.WritePropertyName("logs");
                writer.WriteStartArray();
                foreach (var item in Logs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId");
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(LogAnalyticsDestinationType))
            {
                writer.WritePropertyName("logAnalyticsDestinationType");
                writer.WriteStringValue(LogAnalyticsDestinationType);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DiagnosticSettingsResource DeserializeDiagnosticSettingsResource(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> storageAccountId = default;
            Optional<string> serviceBusRuleId = default;
            Optional<string> eventHubAuthorizationRuleId = default;
            Optional<string> eventHubName = default;
            Optional<IList<MetricSettings>> metrics = default;
            Optional<IList<LogSettings>> logs = default;
            Optional<string> workspaceId = default;
            Optional<string> logAnalyticsDestinationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccountId"))
                        {
                            storageAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceBusRuleId"))
                        {
                            serviceBusRuleId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventHubAuthorizationRuleId"))
                        {
                            eventHubAuthorizationRuleId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventHubName"))
                        {
                            eventHubName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metrics"))
                        {
                            List<MetricSettings> array = new List<MetricSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MetricSettings.DeserializeMetricSettings(item));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("logs"))
                        {
                            List<LogSettings> array = new List<LogSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogSettings.DeserializeLogSettings(item));
                            }
                            logs = array;
                            continue;
                        }
                        if (property0.NameEquals("workspaceId"))
                        {
                            workspaceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsDestinationType"))
                        {
                            logAnalyticsDestinationType = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DiagnosticSettingsResource(id.Value, name.Value, type.Value, storageAccountId.Value, serviceBusRuleId.Value, eventHubAuthorizationRuleId.Value, eventHubName.Value, Optional.ToList(metrics), Optional.ToList(logs), workspaceId.Value, logAnalyticsDestinationType.Value);
        }
    }
}
