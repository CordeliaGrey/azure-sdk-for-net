// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MonitoringSignalBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WritePropertyName("signalType"u8);
            writer.WriteStringValue(SignalType.ToString());
            writer.WriteEndObject();
        }

        internal static MonitoringSignalBase DeserializeMonitoringSignalBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("signalType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Custom": return CustomMonitoringSignal.DeserializeCustomMonitoringSignal(element);
                    case "DataDrift": return DataDriftMonitoringSignal.DeserializeDataDriftMonitoringSignal(element);
                    case "DataQuality": return DataQualityMonitoringSignal.DeserializeDataQualityMonitoringSignal(element);
                    case "FeatureAttributionDrift": return FeatureAttributionDriftMonitoringSignal.DeserializeFeatureAttributionDriftMonitoringSignal(element);
                    case "GenerationSafetyQuality": return GenerationSafetyQualityMonitoringSignal.DeserializeGenerationSafetyQualityMonitoringSignal(element);
                    case "GenerationTokenStatistics": return GenerationTokenStatisticsSignal.DeserializeGenerationTokenStatisticsSignal(element);
                    case "ModelPerformance": return ModelPerformanceSignal.DeserializeModelPerformanceSignal(element);
                    case "PredictionDrift": return PredictionDriftMonitoringSignal.DeserializePredictionDriftMonitoringSignal(element);
                }
            }
            return UnknownMonitoringSignalBase.DeserializeUnknownMonitoringSignalBase(element);
        }
    }
}
