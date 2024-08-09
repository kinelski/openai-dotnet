// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Batch
{
    internal partial class InternalBatchRequestInput : IJsonModel<InternalBatchRequestInput>
    {
        void IJsonModel<InternalBatchRequestInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalBatchRequestInput)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("custom_id") != true && Optional.IsDefined(CustomId))
            {
                writer.WritePropertyName("custom_id"u8);
                writer.WriteStringValue(CustomId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("method") != true && Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method.Value.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("url") != true && Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url.AbsoluteUri);
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

        InternalBatchRequestInput IJsonModel<InternalBatchRequestInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalBatchRequestInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalBatchRequestInput(document.RootElement, options);
        }

        internal static InternalBatchRequestInput DeserializeInternalBatchRequestInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customId = default;
            InternalBatchRequestInputMethod? method = default;
            Uri url = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("custom_id"u8))
                {
                    customId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = new InternalBatchRequestInputMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalBatchRequestInput(customId, method, url, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalBatchRequestInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchRequestInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalBatchRequestInput)} does not support writing '{options.Format}' format.");
            }
        }

        InternalBatchRequestInput IPersistableModel<InternalBatchRequestInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchRequestInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalBatchRequestInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalBatchRequestInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalBatchRequestInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalBatchRequestInput FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalBatchRequestInput(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
