using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[ImageName("BookMark")]
public class BookMark : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public BookMark()
    {
        Code = $"BOOKMARK-{Guid.NewGuid():N}";
        Name = "New Bookmark";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? FolderId { get; set; }

    [ForeignKey(nameof(FolderId))]
    public virtual Folder? Folder { get; set; }

    [MaxLength(2048)]
    public virtual string? SourceUrl { get; set; }

    [MaxLength(512)]
    public virtual string? FilePath { get; set; }

    public virtual bool IsImported { get; set; }

    public virtual DateTime? ImportedOnUtc { get; set; }

    public void Validate()
    {
        const string entityName = "BookMark";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureSource(entityName, SourceUrl, FilePath);
        DocumentValidationMessages.EnsureBookmarkImportState(entityName, IsImported, ImportedOnUtc);
    }
}