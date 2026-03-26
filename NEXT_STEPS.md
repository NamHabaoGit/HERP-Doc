# Next Steps

1. Confirm the standalone `HERP-Doc` GitHub repository is rooted at `D:\HERP\XAF\Modules\Document` only.
2. Add or refine a module-local `.gitignore` for .NET/XAF build outputs after the repo refresh lands.
3. Run the Win shell again and verify the `Document` group remains visible with mandatory shell registration, and that the `Default` group no longer shows `Document` business objects.
4. If the Win shell is stable, confirm the same mandatory registration path in Blazor and WebApi.
5. Rebuild the Document module and verify there are no more leftover pre-rename type names such as HERPBaseModule or HERPMasterDataModule.
6. Review `doc/old_module/document_module/METADATA_MAPPING.md` and confirm ambiguous entity/field mappings before using it to generate XAF metadata.
7. Replace the default parser, translation gateway, and data-service executor with production adapters.
8. Add EF migration and validate the generated schema plus delete behaviors.
9. Extend the QA suite with adapter-backed parity tests once real import/translation providers are wired.
10. Benchmark import, terminology extraction, and batch translation on large documents.
