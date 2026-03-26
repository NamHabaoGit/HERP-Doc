using HERP.Document.BusinessObjects;
﻿

namespace HERP.Document.Services.Workflow;

public class FolderService
{
    public void MoveTo(Folder folder, Folder? parent)
    {
        ArgumentNullException.ThrowIfNull(folder);

        folder.Parent = parent;
        folder.ParentId = parent?.ID;
        RebuildPath(folder);
    }

    public void RebuildPath(Folder folder)
    {
        ArgumentNullException.ThrowIfNull(folder);
        folder.NormalizedPath = BuildPath(folder);
    }

    public void RebuildPathTree(Folder folder)
    {
        ArgumentNullException.ThrowIfNull(folder);
        RebuildPath(folder);

        foreach (var child in folder.Children)
        {
            child.Parent = folder;
            child.ParentId = folder.ID;
            RebuildPathTree(child);
        }
    }

    private static string BuildPath(Folder folder)
    {
        var segments = new Stack<string>();
        var current = folder;

        while (current is not null)
        {
            segments.Push(current.Name);
            current = current.Parent!;
        }

        return string.Join("/", segments.Where(segment => !string.IsNullOrWhiteSpace(segment)));
    }
}
