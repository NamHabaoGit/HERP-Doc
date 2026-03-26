# Measurement Plan

## Import
- Measure time to split a large source into `Audio` rows at sizes 100, 1,000, and 5,000 segments.
- Capture allocated memory before and after import.

## Terminology Extraction
- Measure extraction time on the same document sizes.
- Record number of unique term candidates and duplicate suppression ratio.

## Batch Translation
- Measure prompt generation and translation result mapping back to `Audio`.
- Inspect query shape for loading `Video -> Audios -> Terms -> TermLocations` to avoid N+1 patterns.
