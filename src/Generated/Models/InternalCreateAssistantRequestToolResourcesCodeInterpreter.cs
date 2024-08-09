// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateAssistantRequestToolResourcesCodeInterpreter
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        public InternalCreateAssistantRequestToolResourcesCodeInterpreter()
        {
            FileIds = new ChangeTrackingList<string>();
        }

        internal InternalCreateAssistantRequestToolResourcesCodeInterpreter(IList<string> fileIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileIds = fileIds;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public IList<string> FileIds { get; }
    }
}
