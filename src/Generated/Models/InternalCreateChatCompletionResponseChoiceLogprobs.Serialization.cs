// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionResponseChoiceLogprobs : IJsonModel<InternalCreateChatCompletionResponseChoiceLogprobs>
    {
        void IJsonModel<InternalCreateChatCompletionResponseChoiceLogprobs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionResponseChoiceLogprobs)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("content") != true)
            {
                if (Content != null && Optional.IsCollectionDefined(Content))
                {
                    writer.WritePropertyName("content"u8);
                    writer.WriteStartArray();
                    foreach (var item in Content)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("content");
                }
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

        InternalCreateChatCompletionResponseChoiceLogprobs IJsonModel<InternalCreateChatCompletionResponseChoiceLogprobs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionResponseChoiceLogprobs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateChatCompletionResponseChoiceLogprobs(document.RootElement, options);
        }

        internal static InternalCreateChatCompletionResponseChoiceLogprobs DeserializeInternalCreateChatCompletionResponseChoiceLogprobs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ChatTokenLogProbabilityInfo> content = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        content = new ChangeTrackingList<ChatTokenLogProbabilityInfo>();
                        continue;
                    }
                    List<ChatTokenLogProbabilityInfo> array = new List<ChatTokenLogProbabilityInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatTokenLogProbabilityInfo.DeserializeChatTokenLogProbabilityInfo(item, options));
                    }
                    content = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalCreateChatCompletionResponseChoiceLogprobs(content, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalCreateChatCompletionResponseChoiceLogprobs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionResponseChoiceLogprobs)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateChatCompletionResponseChoiceLogprobs IPersistableModel<InternalCreateChatCompletionResponseChoiceLogprobs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionResponseChoiceLogprobs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalCreateChatCompletionResponseChoiceLogprobs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionResponseChoiceLogprobs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateChatCompletionResponseChoiceLogprobs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalCreateChatCompletionResponseChoiceLogprobs FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateChatCompletionResponseChoiceLogprobs(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
