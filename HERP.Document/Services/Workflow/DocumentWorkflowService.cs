using HERP.Base.Enums;
using HERP.Document.BusinessObjects;
using HERP.Base.Exceptions;


using HERP.Document.Enums;
using HERP.Document.Validation;

namespace HERP.Document.Services.Workflow;

public class DocumentWorkflowService
{
    public Video CreateDraft(Folder folder, Language sourceLanguage, string title, DocumentMode mode)
    {
        ArgumentNullException.ThrowIfNull(folder);
        ArgumentNullException.ThrowIfNull(sourceLanguage);
        DocumentValidationMessages.EnsureText("Video", title);

        return new Video
        {
            CompanyId = folder.CompanyId,
            BranchId = folder.BranchId,
            Folder = folder,
            FolderId = folder.ID,
            SourceLanguage = sourceLanguage,
            SourceLanguageId = sourceLanguage.ID,
            Code = $"VIDEO-{Guid.NewGuid():N}",
            Name = title.Trim(),
            DocumentNo = $"DOC-{DateTime.UtcNow:yyyyMMddHHmmss}",
            Mode = mode,
            Status = DocumentStatus.Draft
        };
    }

    public void SubmitForReview(Video video)
    {
        ArgumentNullException.ThrowIfNull(video);

        if (video.Status != DocumentStatus.Draft)
        {
            throw new InvalidOperationException("Only draft documents can be submitted.");
        }

        video.Status = DocumentStatus.Submitted;
    }

    public void Publish(Video video)
    {
        ArgumentNullException.ThrowIfNull(video);

        if (video.Status != DocumentStatus.Approved && video.Status != DocumentStatus.Submitted)
        {
            throw new InvalidOperationException("Document must be submitted or approved before publishing.");
        }

        video.Status = DocumentStatus.Posted;
        video.PostingDate ??= DateTime.Today;
    }
}


