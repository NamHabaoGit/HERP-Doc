using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.Enums;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[ImageName("Video")]
[NavigationItem("Document")]
public class Video : HerpDocumentObject, IHerpBusinessValidatable
{
    public Video()
    {
        Code = $"VIDEO-{Guid.NewGuid():N}";
        Name = "New Video";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? FolderId { get; set; }

    [ForeignKey(nameof(FolderId))]
    public virtual Folder? Folder { get; set; }

    public virtual Guid? SourceBookmarkId { get; set; }

    [ForeignKey(nameof(SourceBookmarkId))]
    public virtual BookMark? SourceBookmark { get; set; }

    public virtual Guid? SourceLanguageId { get; set; }

    [ForeignKey(nameof(SourceLanguageId))]
    public virtual Language? SourceLanguage { get; set; }

    public virtual Guid? TargetLanguageId { get; set; }

    [ForeignKey(nameof(TargetLanguageId))]
    public virtual Language? TargetLanguage { get; set; }

    public virtual DocumentMode Mode { get; set; } = DocumentMode.Translation;

    [MaxLength(2048)]
    public virtual string? SourceUrl { get; set; }

    [MaxLength(128)]
    public virtual string? ExternalReference { get; set; }

    public virtual IList<Element> Elements { get; set; } = new ObservableCollection<Element>();
    public virtual IList<Paragraph> Paragraphs { get; set; } = new ObservableCollection<Paragraph>();
    public virtual IList<ParagraphStyle> ParagraphStyles { get; set; } = new ObservableCollection<ParagraphStyle>();
    public virtual IList<Media> MediaItems { get; set; } = new ObservableCollection<Media>();
    public virtual IList<Term> Terms { get; set; } = new ObservableCollection<Term>();
    public virtual IList<ElementBatch> Batches { get; set; } = new ObservableCollection<ElementBatch>();
    public virtual IList<TranslateObject> TranslateObjects { get; set; } = new ObservableCollection<TranslateObject>();
    public virtual IList<ObjectRelation> ObjectRelations { get; set; } = new ObservableCollection<ObjectRelation>();

    [NotMapped]
    public virtual int ElementCount => Elements.Count;

    [NotMapped]
    public virtual int ProcessedElementCount => Elements.Count(element => element.IsProcessed);

    [NotMapped]
    public virtual int PendingElementCount => Elements.Count(element => !element.IsProcessed);

    [NotMapped]
    [Browsable(false)]
    public virtual bool HasImportedSource => SourceBookmarkId.HasValue || !string.IsNullOrWhiteSpace(SourceUrl);

    public void Validate()
    {
        const string entityName = "Video";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureFolder(entityName, FolderId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureLanguage(entityName, SourceLanguageId);
    }
}