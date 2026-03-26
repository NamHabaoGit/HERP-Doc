using HERP.Base.Exceptions;
using HERP.Document.BusinessObjects;
using HERP.Base.Messages;
using HERP.Base.Validation;

using HERP.Document.Messages;

namespace HERP.Document.Validation;

public static class DocumentValidationMessages
{
    public static HerpMessage BatchTargetLanguageMismatch(string entityName) => Error(DocumentMessageKeys.BatchTargetLanguageMismatch, "{EntityName} target language must match the batch target language.", entityName);
    public static HerpMessage BookmarkImportStateInvalid(string entityName) => Error(DocumentMessageKeys.BookmarkImportStateInvalid, "{EntityName} import state and import timestamp must stay in sync.", entityName);
    public static HerpMessage BranchRequired(string entityName) => Error(DocumentMessageKeys.BranchRequired, "{EntityName} requires a branch.", entityName);
    public static HerpMessage CodeRequired(string entityName) => Error(DocumentMessageKeys.CodeRequired, "{EntityName} code is required.", entityName);
    public static HerpMessage CompanyRequired(string entityName) => Error(DocumentMessageKeys.CompanyRequired, "{EntityName} requires a company.", entityName);
    public static HerpMessage DataServiceRequired(string entityName) => Error(DocumentMessageKeys.DataServiceRequired, "{EntityName} requires a data service.", entityName);
    public static HerpMessage DuplicateParameterCode(string entityName) => Error(DocumentMessageKeys.DuplicateParameterCode, "{EntityName} parameter codes must be unique within the same service.", entityName);
    public static HerpMessage ElementBatchRequired(string entityName) => Error(DocumentMessageKeys.ElementBatchRequired, "{EntityName} requires an element batch.", entityName);
    public static HerpMessage EndpointRequired(string entityName) => Error(DocumentMessageKeys.EndpointRequired, "{EntityName} endpoint is required.", entityName);
    public static HerpMessage ExternalObjectIdRequired(string entityName) => Error(DocumentMessageKeys.ExternalObjectIdRequired, "{EntityName} external object id is required.", entityName);
    public static HerpMessage FolderRequired(string entityName) => Error(DocumentMessageKeys.FolderRequired, "{EntityName} requires a folder.", entityName);
    public static HerpMessage LanguageRequired(string entityName) => Error(DocumentMessageKeys.LanguageRequired, "{EntityName} requires a language.", entityName);
    public static HerpMessage LengthInvalid(string entityName) => Error(DocumentMessageKeys.LengthInvalid, "{EntityName} length must be greater than or equal to zero.", entityName);
    public static HerpMessage NameRequired(string entityName) => Error(DocumentMessageKeys.NameRequired, "{EntityName} name is required.", entityName);
    public static HerpMessage ParentFolderCycleDetected(string entityName) => Error(DocumentMessageKeys.ParentFolderCycleDetected, "{EntityName} parent chain cannot contain the folder itself.", entityName);
    public static HerpMessage ParentFolderInvalid(string entityName) => Error(DocumentMessageKeys.ParentFolderInvalid, "{EntityName} cannot use itself as parent.", entityName);
    public static HerpMessage SequenceInvalid(string entityName) => Error(DocumentMessageKeys.SequenceInvalid, "{EntityName} sequence must be greater than or equal to zero.", entityName);
    public static HerpMessage SourceRequired(string entityName) => Error(DocumentMessageKeys.SourceRequired, "{EntityName} requires a source url, file path, or html payload.", entityName);
    public static HerpMessage StartIndexInvalid(string entityName) => Error(DocumentMessageKeys.StartIndexInvalid, "{EntityName} start index must be greater than or equal to zero.", entityName);
    public static HerpMessage TargetLanguageMatchesSource(string entityName) => Error(DocumentMessageKeys.TargetLanguageMatchesSource, "{EntityName} target language must differ from the source language.", entityName);
    public static HerpMessage TargetLanguageRequired(string entityName) => Error(DocumentMessageKeys.TargetLanguageRequired, "{EntityName} target language is required.", entityName);
    public static HerpMessage TermRequired(string entityName) => Error(DocumentMessageKeys.TermRequired, "{EntityName} term text is required.", entityName);
    public static HerpMessage TextRequired(string entityName) => Error(DocumentMessageKeys.TextRequired, "{EntityName} text is required.", entityName);
    public static HerpMessage TimeRangeInvalid(string entityName) => Error(DocumentMessageKeys.TimeRangeInvalid, "{EntityName} end time must be greater than or equal to start time.", entityName);
    public static HerpMessage VideoRequired(string entityName) => Error(DocumentMessageKeys.VideoRequired, "{EntityName} requires a document root.", entityName);

    public static void EnsureCodeAndName(string entityName, string? code, string? name)
    {
        HerpValidationGuard.Required(code, () => CodeRequired(entityName));
        HerpValidationGuard.Required(name, () => NameRequired(entityName));
    }

    public static void EnsureCompany(string entityName, Guid? companyId)
    {
        HerpValidationGuard.Required(companyId, () => CompanyRequired(entityName));
    }

    public static void EnsureBranch(string entityName, Guid? branchId)
    {
        HerpValidationGuard.Required(branchId, () => BranchRequired(entityName));
    }

    public static void EnsureFolder(string entityName, Guid? folderId)
    {
        HerpValidationGuard.Required(folderId, () => FolderRequired(entityName));
    }

    public static void EnsureLanguage(string entityName, Guid? languageId)
    {
        HerpValidationGuard.Required(languageId, () => LanguageRequired(entityName));
    }

    public static void EnsureTargetLanguage(string entityName, Guid? languageId)
    {
        HerpValidationGuard.Required(languageId, () => TargetLanguageRequired(entityName));
    }

    public static void EnsureVideo(string entityName, Guid? videoId)
    {
        HerpValidationGuard.Required(videoId, () => VideoRequired(entityName));
    }

    public static void EnsureElementBatch(string entityName, Guid? elementBatchId)
    {
        HerpValidationGuard.Required(elementBatchId, () => ElementBatchRequired(entityName));
    }

    public static void EnsureSequence(string entityName, int sequence)
    {
        HerpValidationGuard.Range(sequence, 0, int.MaxValue, () => SequenceInvalid(entityName));
    }

    public static void EnsureStartIndex(string entityName, int startIndex)
    {
        HerpValidationGuard.Range(startIndex, 0, int.MaxValue, () => StartIndexInvalid(entityName));
    }

    public static void EnsureLength(string entityName, int length)
    {
        HerpValidationGuard.Range(length, 0, int.MaxValue, () => LengthInvalid(entityName));
    }

    public static void EnsureValidParentFolder(string entityName, Guid id, Guid? parentId)
    {
        if (parentId.HasValue && parentId.Value == id)
        {
            throw HerpExceptionFactory.Validation(ParentFolderInvalid(entityName));
        }
    }

    public static void EnsureParentChain(string entityName, Guid id, Guid? parentId, Func<Guid?, Guid?> parentResolver)
    {
        if (!parentId.HasValue)
        {
            return;
        }

        var visited = new HashSet<Guid> { id };
        var currentParentId = parentId;

        while (currentParentId.HasValue)
        {
            if (!visited.Add(currentParentId.Value))
            {
                throw HerpExceptionFactory.Validation(ParentFolderCycleDetected(entityName));
            }

            currentParentId = parentResolver(currentParentId);
        }
    }

    public static void EnsureSource(string entityName, params string?[] values)
    {
        if (values.All(string.IsNullOrWhiteSpace))
        {
            throw HerpExceptionFactory.Validation(SourceRequired(entityName));
        }
    }

    public static void EnsureText(string entityName, string? value)
    {
        HerpValidationGuard.Required(value, () => TextRequired(entityName));
    }

    public static void EnsureTimeRange(string entityName, TimeSpan? startTime, TimeSpan? endTime)
    {
        if (startTime.HasValue && endTime.HasValue && endTime.Value < startTime.Value)
        {
            throw HerpExceptionFactory.Validation(TimeRangeInvalid(entityName));
        }
    }

    public static void EnsureTerm(string entityName, string? value)
    {
        HerpValidationGuard.Required(value, () => TermRequired(entityName));
    }

    public static void EnsureExternalObjectId(string entityName, string? value)
    {
        HerpValidationGuard.Required(value, () => ExternalObjectIdRequired(entityName));
    }

    public static void EnsureEndpoint(string entityName, string? value)
    {
        HerpValidationGuard.Required(value, () => EndpointRequired(entityName));
    }

    public static void EnsureDataService(string entityName, Guid? dataServiceId)
    {
        HerpValidationGuard.Required(dataServiceId, () => DataServiceRequired(entityName));
    }

    public static void EnsureDifferentLanguage(string entityName, Guid? sourceLanguageId, Guid? targetLanguageId)
    {
        if (sourceLanguageId.HasValue && targetLanguageId.HasValue && sourceLanguageId.Value == targetLanguageId.Value)
        {
            throw HerpExceptionFactory.Validation(TargetLanguageMatchesSource(entityName));
        }
    }

    public static void EnsureBatchTargetLanguage(string entityName, Guid? batchTargetLanguageId, Guid? targetLanguageId)
    {
        if (batchTargetLanguageId.HasValue && targetLanguageId.HasValue && batchTargetLanguageId.Value != targetLanguageId.Value)
        {
            throw HerpExceptionFactory.Validation(BatchTargetLanguageMismatch(entityName));
        }
    }

    public static void EnsureUniqueParameterCodes(string entityName, IEnumerable<DataServiceParameter> parameters)
    {
        var duplicateCode = parameters
            .Where(parameter => !string.IsNullOrWhiteSpace(parameter.Code))
            .GroupBy(parameter => parameter.Code!.Trim(), StringComparer.OrdinalIgnoreCase)
            .FirstOrDefault(group => group.Count() > 1);

        if (duplicateCode is not null)
        {
            throw HerpExceptionFactory.Validation(DuplicateParameterCode(entityName));
        }
    }

    public static void EnsureBookmarkImportState(string entityName, bool isImported, DateTime? importedOnUtc)
    {
        var hasImportedTimestamp = importedOnUtc.HasValue;
        if (isImported != hasImportedTimestamp)
        {
            throw HerpExceptionFactory.Validation(BookmarkImportStateInvalid(entityName));
        }
    }

    private static HerpMessage Error(string key, string text, string entityName)
    {
        return HerpMessageFactory.Error(
            key,
            text,
            new Dictionary<string, string>
            {
                ["EntityName"] = entityName
            });
    }
}