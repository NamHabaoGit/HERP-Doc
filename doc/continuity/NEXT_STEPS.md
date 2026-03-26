# Next Steps (priority order)

0. Validate the new `Document` module foundation on a developer machine:
   - use `docs/old_module/document_module/METADATA_MAPPING.md` as the canonical input when CodeAgent starts applying XAF/UI metadata onto current entities
   - fix the local `.NET` restore / MSBuild workload issue, then run `dotnet test tests/XAF/Modules/Document/HERP.Document.Tests/HERP.Document.Tests.csproj`
   - run `scripts/run-document-tests.ps1` as the preferred local regression command once the dev environment is healthy
   - run restore/build for `XAF/Modules/Document/HERP.Document/HERP.Document.csproj`
   - verify the new `Document` navigation group, module-level XAF model captions/views, and custom legacy-derived icons plus XAF-sized variants in a running app
   - generate the first migration for the Document schema
   - replace default parser/translation/data-service stubs with real adapters once provider choices are confirmed

1. Finalize the centralized cross-cutting layer for XAF:
   - standardize `ValidationRules`, `AppearanceRules`, `CriteriaCatalog`, `FilterDefinitions`, `Helpers`
   - decide which rules stay as BO attributes and which move to controllers/services/catalogs
   - standardize criteria/filter constant names to avoid scattered string literals
   - replace `PassthroughHerpMessageLocalizer` with a real localization adapter

2. Complete settings architecture:
   - verify the fallback chain `User -> Company -> System -> Default`
   - create XAF administration UI for `SystemSetting`, `CompanySetting`, `UserSetting`
   - finalize the naming convention for setting keys

3. Implement the remaining parts of `docs/cross-cutting-architecture.md`:
   - shared validation and criteria helpers
   - localization key naming convention
   - format/parse helpers that can read company or user settings
   - real notification and logging adapters instead of null implementations
   - stronger `HerpValidationGuard` helpers for unique, regex, date, and state-transition rules
   - better Blazor dialog UX than browser `alert/confirm` if needed
   - better MAUI dialog support for input dialog and action sheet flows if needed

4. Write team workflow guidelines per module:
   - branch strategy
   - migration ownership
   - rules for editing shell app, model, and navigation without cross-team conflicts
   - keep solution profiles per module stable

5. Verify the subset-module model on a real developer machine:
   - open `HERP.Purchasing.slnx`, `HERP.Inventory.slnx`, `HERP.Sales.slnx`
   - confirm the app still boots with only `Base + MasterData + owned module`
   - repeat for `CRM`, `HRM`, `Projects`, `Integration`, `Reporting`, `Workflow`, `Administration`

6. Tighten audit if needed:
   - implement `IAuditContextProvider` that resolves the real `ApplicationUser.Id`

7. Standardize notification and logging runtime:
   - decide whether notification logs belong in `HERP.Workflow` or `HERP.Administration`
   - decide whether logging should wrap `ILogger<T>` or persist to DB/event store
   - standardize correlation id propagation across WebApi, Blazor, Win, and integration jobs

8. Separate Clean Architecture boundaries for the first sample module:
   - domain entities
   - application use cases
   - infrastructure persistence
   - prevent XAF UI from bypassing the application boundary

9. Run restore/build on a developer machine with NuGet/DevExpress access to verify the scaffold compiles cleanly.
   - configure `AndroidSdkDirectory` or install the Android SDK so `MAUI/HERP.slnx` can build the `net10.0-android` target
   - review remaining non-blocking warnings (`CS8632`, obsolete MAUI APIs, `NU1903` on `Microsoft.Build`)

10. Validate the multi-agent pack with one pilot slice (`Supplier`).

11. Formalize the multi-agent handoff payload as JSON schema with examples.

12. Add coding standards (`.editorconfig`, analyzers, nullable + warnings as errors).

13. Add CI pipeline (build + test + format + migration check).

14. Keep module continuity governance consistent:
   - update `XAF/Modules/<Module>/NEXT_STEPS.md` and `REQUEST_RESULT_LOG.md` whenever module scope changes
   - keep root continuity files focused on project architecture and cross-module coordination

15. Use `docs/module-delivery-plan.md` as the canonical assignment board when handing modules to devs or agents.

16. Keep `XAF/HERP.slnx` module folders aligned with physical module layout:
   - add new XAF module projects under `/Modules/<Module>/`
   - keep each module folder limited to its three projects (`Base`, `Blazor`, `Win`) unless the architecture changes intentionally

17. Keep repository hygiene stable:
   - ensure temporary IDE/build/telemetry artifacts stay ignored (`.vs`, `bin`, `obj`, `.dotnet`)
   - if legacy tracked temp files reappear, remove them from the index instead of committing them again

