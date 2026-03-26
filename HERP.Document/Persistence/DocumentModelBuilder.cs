using HERP.Document.BusinessObjects;
﻿






using Microsoft.EntityFrameworkCore;
using DocumentDictionary = HERP.Document.BusinessObjects.Dictionary;

namespace HERP.Document.Persistence;

public static class DocumentModelBuilder
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Folder>().HasIndex(x => new { x.CompanyId, x.Code }).IsUnique();
        modelBuilder.Entity<Video>().HasIndex(x => new { x.CompanyId, x.DocumentNo }).IsUnique();
        modelBuilder.Entity<BookMark>().HasIndex(x => new { x.CompanyId, x.Code }).IsUnique();
        modelBuilder.Entity<ObjectRelation>().HasIndex(x => new { x.CompanyId, x.ExternalObjectType, x.ExternalObjectId });
        modelBuilder.Entity<Language>().HasIndex(x => x.Code).IsUnique();
        modelBuilder.Entity<Voice>().HasIndex(x => new { x.LanguageId, x.Code }).IsUnique();
        modelBuilder.Entity<DataService>().HasIndex(x => x.Code).IsUnique();
        modelBuilder.Entity<SoftwareServiceType>().HasIndex(x => x.Code).IsUnique();
        modelBuilder.Entity<Term>().HasIndex(x => new { x.VideoId, x.LanguageId, x.SourceTerm });
        modelBuilder.Entity<DocumentDictionary>().HasIndex(x => x.Code).IsUnique();
        modelBuilder.Entity<ElementBatch>().HasIndex(x => new { x.VideoId, x.TargetLanguageId, x.DocumentNo }).IsUnique();

        modelBuilder.Entity<Folder>()
            .HasMany(x => x.Children)
            .WithOne(x => x.Parent)
            .HasForeignKey(x => x.ParentId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Folder>()
            .HasMany(x => x.Videos)
            .WithOne(x => x.Folder)
            .HasForeignKey(x => x.FolderId)
            .OnDelete(DeleteBehavior.SetNull);

        ConfigureVideoRelationships(modelBuilder);

        modelBuilder.Entity<Paragraph>()
            .HasMany(x => x.Elements)
            .WithOne(x => x.Paragraph)
            .HasForeignKey(x => x.ParagraphId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Paragraph>()
            .HasMany(x => x.MediaItems)
            .WithOne(x => x.Paragraph)
            .HasForeignKey(x => x.ParagraphId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Term>()
            .HasMany(x => x.Locations)
            .WithOne(x => x.Term)
            .HasForeignKey(x => x.TermId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Term>()
            .HasMany(x => x.Corrections)
            .WithOne(x => x.Term)
            .HasForeignKey(x => x.TermId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<TermCorrection>()
            .HasMany(x => x.LocationCorrections)
            .WithOne(x => x.TermCorrection)
            .HasForeignKey(x => x.TermCorrectionId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<TermCorrection>()
            .HasMany(x => x.Options)
            .WithOne(x => x.TermCorrection)
            .HasForeignKey(x => x.TermCorrectionId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<DocumentDictionary>()
            .HasMany(x => x.Words)
            .WithOne(x => x.Dictionary)
            .HasForeignKey(x => x.DictionaryId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<DictionaryWord>()
            .HasMany(x => x.Translations)
            .WithOne(x => x.DictionaryWord)
            .HasForeignKey(x => x.DictionaryWordId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<SpellingWord>()
            .HasMany(x => x.LanguageSpellings)
            .WithOne(x => x.SpellingWord)
            .HasForeignKey(x => x.SpellingWordId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Word>()
            .HasMany(x => x.NoSignVariants)
            .WithOne(x => x.Word)
            .HasForeignKey(x => x.WordId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ElementBatch>()
            .HasMany(x => x.Translations)
            .WithOne(x => x.ElementBatch)
            .HasForeignKey(x => x.ElementBatchId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<DataService>()
            .HasMany(x => x.Parameters)
            .WithOne(x => x.DataService)
            .HasForeignKey(x => x.DataServiceId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<DataService>()
            .HasMany(x => x.Voices)
            .WithOne(x => x.DataService)
            .HasForeignKey(x => x.DataServiceId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<DataService>()
            .HasMany(x => x.Logs)
            .WithOne(x => x.DataService)
            .HasForeignKey(x => x.DataServiceId)
            .OnDelete(DeleteBehavior.Cascade);
    }

    private static void ConfigureVideoRelationships(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Video>()
            .HasMany(x => x.Elements)
            .WithOne(x => x.Video)
            .HasForeignKey(x => x.VideoId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Video>()
            .HasMany(x => x.Paragraphs)
            .WithOne(x => x.Video)
            .HasForeignKey(x => x.VideoId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Video>()
            .HasMany(x => x.ParagraphStyles)
            .WithOne(x => x.Video)
            .HasForeignKey(x => x.VideoId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Video>()
            .HasMany(x => x.MediaItems)
            .WithOne(x => x.Video)
            .HasForeignKey(x => x.VideoId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Video>()
            .HasMany(x => x.Terms)
            .WithOne(x => x.Video)
            .HasForeignKey(x => x.VideoId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Video>()
            .HasMany(x => x.Batches)
            .WithOne(x => x.Video)
            .HasForeignKey(x => x.VideoId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Video>()
            .HasMany(x => x.TranslateObjects)
            .WithOne(x => x.Video)
            .HasForeignKey(x => x.VideoId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}

