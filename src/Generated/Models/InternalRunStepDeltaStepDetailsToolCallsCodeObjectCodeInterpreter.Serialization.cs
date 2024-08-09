// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter : IJsonModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>
    {
        void IJsonModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("input") != true && Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteStringValue(Input);
            }
            if (SerializedAdditionalRawData?.ContainsKey("outputs") != true && Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter IJsonModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(document.RootElement, options);
        }

        internal static InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string input = default;
            IReadOnlyList<RunStepUpdateCodeInterpreterOutput> outputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    input = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RunStepUpdateCodeInterpreterOutput> array = new List<RunStepUpdateCodeInterpreterOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunStepUpdateCodeInterpreterOutput.DeserializeRunStepUpdateCodeInterpreterOutput(item, options));
                    }
                    outputs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(input, outputs ?? new ChangeTrackingList<RunStepUpdateCodeInterpreterOutput>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
