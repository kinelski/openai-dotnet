// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionStreamResponseUsage
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalCreateChatCompletionStreamResponseUsage(int completionTokens, int promptTokens, int totalTokens)
        {
            CompletionTokens = completionTokens;
            PromptTokens = promptTokens;
            TotalTokens = totalTokens;
        }

        internal InternalCreateChatCompletionStreamResponseUsage(int completionTokens, int promptTokens, int totalTokens, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CompletionTokens = completionTokens;
            PromptTokens = promptTokens;
            TotalTokens = totalTokens;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateChatCompletionStreamResponseUsage()
        {
        }

        public int CompletionTokens { get; }
        public int PromptTokens { get; }
        public int TotalTokens { get; }
    }
}
