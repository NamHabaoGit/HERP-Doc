using HERP.Document.BusinessObjects;
﻿

namespace HERP.Document.Contracts;

public interface IHtmlContentMapper
{
    IReadOnlyList<string> ExtractBlocks(string html);

    string BuildHtml(Video video);
}

