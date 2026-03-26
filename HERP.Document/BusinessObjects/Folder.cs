using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[ImageName("Folder")]
[NavigationItem("Document")]
public class Folder : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public Folder()
    {
        Code = $"FOLDER-{Guid.NewGuid():N}";
        Name = "New Folder";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? ParentId { get; set; }

    [ForeignKey(nameof(ParentId))]
    public virtual Folder? Parent { get; set; }

    [MaxLength(512)]
    public virtual string? NormalizedPath { get; set; }

    public virtual IList<Folder> Children { get; set; } = new ObservableCollection<Folder>();
    public virtual IList<Video> Videos { get; set; } = new ObservableCollection<Video>();
    public virtual IList<BookMark> BookMarks { get; set; } = new ObservableCollection<BookMark>();
    public virtual IList<ObjectRelation> ObjectRelations { get; set; } = new ObservableCollection<ObjectRelation>();

    [NotMapped]
    public virtual string DisplayPath => string.IsNullOrWhiteSpace(NormalizedPath) ? Name : NormalizedPath;

    [NotMapped]
    public virtual int ChildFolderCount => Children.Count;

    [NotMapped]
    public virtual int VideoCount => Videos.Count;

    [NotMapped]
    public virtual int BookmarkCount => BookMarks.Count;

    [NotMapped]
    [Browsable(false)]
    public virtual int Depth
    {
        get
        {
            var depth = 0;
            var current = Parent;

            while (current is not null)
            {
                depth++;
                current = current.Parent;
            }

            return depth;
        }
    }

    public void Validate()
    {
        const string entityName = "Folder";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureValidParentFolder(entityName, ID, ParentId);
        DocumentValidationMessages.EnsureParentChain(entityName, ID, ParentId, ResolveParentId);
    }

    private Guid? ResolveParentId(Guid? folderId)
    {
        var current = Parent;
        while (current is not null)
        {
            if (current.ID == folderId)
            {
                return current.ParentId;
            }

            current = current.Parent;
        }

        return null;
    }
}
