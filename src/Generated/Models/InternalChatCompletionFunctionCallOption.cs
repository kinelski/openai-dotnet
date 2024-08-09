// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionFunctionCallOption
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        public InternalChatCompletionFunctionCallOption(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        internal InternalChatCompletionFunctionCallOption(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalChatCompletionFunctionCallOption()
        {
        }

        public string Name { get; }
    }
}
