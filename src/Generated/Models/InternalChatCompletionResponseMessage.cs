// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionResponseMessage
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

        internal InternalChatCompletionResponseMessage(IReadOnlyList<ChatMessageContentPart> content, IReadOnlyList<ChatToolCall> toolCalls, ChatMessageRole role, ChatFunctionCall functionCall, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            ToolCalls = toolCalls;
            Role = role;
            FunctionCall = functionCall;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalChatCompletionResponseMessage()
        {
        }
        public IReadOnlyList<ChatToolCall> ToolCalls { get; }
    }
}
