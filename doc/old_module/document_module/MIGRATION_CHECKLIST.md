# Migration Checklist

- Add EF Core migration for the new `Document` schema on a developer machine with DevExpress/NuGet access.
- Review generated indexes for `Video.DocumentNo`, `ElementBatch.DocumentNo`, and language/configuration tables.
- Verify delete behaviors for `Video -> Audio/Paragraph/Term/Batch/TranslateObject` and `Dictionary -> DictionaryWord`.
- Seed baseline reference data if needed: `Language`, `SoftwareServiceType`, `DataService`.
- Validate XAF navigation/model metadata after the migration is applied.
