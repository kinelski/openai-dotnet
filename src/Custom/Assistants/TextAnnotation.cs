using System;

namespace OpenAI.Assistants;

public class TextAnnotation
{
    internal readonly InternalMessageContentTextObjectAnnotation _internalAnnotation;
    private readonly InternalMessageContentTextAnnotationsFileCitationObject _fileSearchCitation;
    private readonly InternalMessageContentTextAnnotationsFilePathObject _codeCitation;

    /// <summary>
    /// The index in the message content at which the citation begins.
    /// </summary>
    public int StartIndex
        => _fileSearchCitation?.StartIndex
        ?? _codeCitation?.StartIndex
        ?? (_internalAnnotation?.SerializedAdditionalRawData?.TryGetValue("start_index", out BinaryData indexData) == true
            ? int.Parse(indexData.ToString())
            : -1);

    /// <summary>
    /// The index in the message content at which the citation ends.
    /// </summary>
    public int EndIndex =>
        _fileSearchCitation?.EndIndex
        ?? _codeCitation?.EndIndex
        ?? (_internalAnnotation?.SerializedAdditionalRawData?.TryGetValue("end_index", out BinaryData indexData) == true
            ? int.Parse(indexData.ToString())
            : -1);

    /// <summary>
    /// The text in the message content that should be replaced.
    /// </summary>
    public string TextToReplace =>
        _fileSearchCitation?.Text
        ?? _codeCitation?.Text
        ?? (_internalAnnotation?.SerializedAdditionalRawData?.TryGetValue("text", out BinaryData textData) == true
            ? textData.ToString()
            : null);

    /// <summary>
    /// The ID of the file cited by the <c>file_search</c> tool for this annotation.
    /// </summary>
    public string InputFileId => _fileSearchCitation?.FileCitation?.FileId;

    /// <summary>
    /// The ID of the file that was generated by the <c>code_interpreter</c> tool for this citation.
    /// </summary>
    public string OutputFileId => _codeCitation?.FilePath?.FileId;

    internal TextAnnotation(InternalMessageContentTextObjectAnnotation internalAnnotation)
    {
        _internalAnnotation = internalAnnotation;
        _fileSearchCitation = internalAnnotation as InternalMessageContentTextAnnotationsFileCitationObject;
        _codeCitation = internalAnnotation as InternalMessageContentTextAnnotationsFilePathObject; ;
    }
}