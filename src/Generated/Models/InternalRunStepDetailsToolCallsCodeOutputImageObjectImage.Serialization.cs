// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsCodeOutputImageObjectImage : IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>
    {
        void IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("file_id") != true)
            {
                writer.WritePropertyName("file_id"u8);
                writer.WriteStringValue(FileId);
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

        InternalRunStepDetailsToolCallsCodeOutputImageObjectImage IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement, options);
        }

        internal static InternalRunStepDetailsToolCallsCodeOutputImageObjectImage DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file_id"u8))
                {
                    fileId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalRunStepDetailsToolCallsCodeOutputImageObjectImage(fileId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsToolCallsCodeOutputImageObjectImage IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalRunStepDetailsToolCallsCodeOutputImageObjectImage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
