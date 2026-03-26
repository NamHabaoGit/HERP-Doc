using HERP.Document.BusinessObjects;
﻿


namespace HERP.Document.Services.Import;

public class BookmarkImportService
{
    private readonly DocumentImportService documentImportService;

    public BookmarkImportService(DocumentImportService? documentImportService = null)
    {
        this.documentImportService = documentImportService ?? new DocumentImportService();
    }

    public Task<IReadOnlyList<HERP.Document.BusinessObjects.Element>> ImportIntoAsync(Video video, BookMark bookMark, CancellationToken cancellationToken = default)
    {
        return documentImportService.ImportAsync(video, bookMark, cancellationToken);
    }

    public void MarkAsQueued(BookMark bookMark)
    {
        ArgumentNullException.ThrowIfNull(bookMark);
        bookMark.ImportedOnUtc = DateTime.UtcNow;
    }
}


