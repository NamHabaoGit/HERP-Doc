using HERP.Document.BusinessObjects;
﻿

namespace HERP.Document.Services.Terminology;

public class TerminologyCorrectionService
{
    public void ApplyTermCorrection(TermCorrection correction)
    {
        ArgumentNullException.ThrowIfNull(correction);
        correction.IsApplied = true;

        if (correction.Term is not null)
        {
            correction.Term.TranslatedTerm = correction.ReplacementText;
        }
    }

    public void ApplyLocationCorrection(TermLocationCorrection correction)
    {
        ArgumentNullException.ThrowIfNull(correction);
        correction.IsApplied = true;
    }
}

