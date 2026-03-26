using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.Collections.ObjectModel;

namespace HERP.Document.BusinessObjects;


[ImageName("Dictionary")]
[NavigationItem("Document")]
public class Dictionary : HerpAuditedObject, IHerpBusinessValidatable
{
    public Dictionary()
    {
        Code = $"DICT-{Guid.NewGuid():N}";
        Name = "Dictionary";
    }

    public virtual IList<DictionaryWord> Words { get; set; } = new ObservableCollection<DictionaryWord>();

    public void Validate()
    {
        DocumentValidationMessages.EnsureCodeAndName("Dictionary", Code, Name);
    }
}


