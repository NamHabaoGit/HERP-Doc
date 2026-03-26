using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HERP.Document.BusinessObjects;


[DefaultClassOptions]
[NavigationItem("Document")]
[ImageName("Language")]
public class Language : HerpAuditedObject, IHerpBusinessValidatable
{
    public Language()
    {
        Code = $"LANG-{Guid.NewGuid():N}";
        Name = "Language";
    }

    [MaxLength(16)]
    public virtual string? IsoCode { get; set; }

    [MaxLength(128)]
    public virtual string? NativeName { get; set; }

    [MaxLength(128)]
    public virtual string? EnglishName { get; set; }

    [MaxLength(32)]
    public virtual string? LocaleCode { get; set; }

    public virtual IList<Voice> Voices { get; set; } = new ObservableCollection<Voice>();

    public void Validate()
    {
        DocumentValidationMessages.EnsureCodeAndName("Language", Code, Name);
    }
}



