using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[ImageName("BatchTranslate")]
public class BatchTranslate : HerpDocumentObject, IHerpBusinessValidatable
{
    public BatchTranslate()
    {
        Code = $"BATCHTRANS-{Guid.NewGuid():N}";
        Name = "Batch Translation";
    }

    public virtual Guid? ElementBatchId { get; set; }

    [ForeignKey(nameof(ElementBatchId))]
    public virtual ElementBatch? ElementBatch { get; set; }

    public virtual Guid? TargetLanguageId { get; set; }

    [ForeignKey(nameof(TargetLanguageId))]
    public virtual Language? TargetLanguage { get; set; }

    [MaxLength(8000)]
    public virtual string? PromptPayload { get; set; }

    [MaxLength(8000)]
    public virtual string? ResultPayload { get; set; }

    public virtual DateTime? AppliedOnUtc { get; set; }

    public void Validate()
    {
        const string entityName = "BatchTranslate";
        DocumentValidationMessages.EnsureElementBatch(entityName, ElementBatchId);
        DocumentValidationMessages.EnsureTargetLanguage(entityName, TargetLanguageId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureBatchTargetLanguage(entityName, ElementBatch?.TargetLanguageId, TargetLanguageId);
        DocumentValidationMessages.EnsureDifferentLanguage(entityName, ElementBatch?.Video?.SourceLanguageId, TargetLanguageId);
    }
}