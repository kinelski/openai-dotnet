// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaContentTextAnnotationsFileCitationObjectFileCitation
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalMessageDeltaContentTextAnnotationsFileCitationObjectFileCitation()
        {
        }

        internal InternalMessageDeltaContentTextAnnotationsFileCitationObjectFileCitation(string fileId, string quote, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            Quote = quote;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string FileId { get; }
        public string Quote { get; }
    }
}
