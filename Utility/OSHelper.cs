using System;
using CsTkinter.Utility.DataTypes;
using Microsoft.Win32;

namespace CsTkinter.Utility;

public static class OSHelper
{
    public static string? AskOpenFile(
        string? windowTitle = null,
        ExtensionFilter[]? filters = null,
        string? defaultDirectory = null
    )
    {
        var ret = AskOpenFile(
            windowTitle ?? "Select a file",
            filters ?? Array.Empty<ExtensionFilter>(),
            defaultDirectory ?? "",
            false
        );
        if(ret.Length >= 1)
        {
            return ret[0];
        }
        return null;
    }
    public static string[] AskOpenFiles(
        string? windowTitle = null,
        ExtensionFilter[]? filters = null,
        string? defaultDirectory = null
    )
    {
        return AskOpenFile(
            windowTitle ?? "Select a file",
            filters ?? Array.Empty<ExtensionFilter>(),
            defaultDirectory ?? "",
            true
        );
    }

    private static string[] AskOpenFile(
        string windowTitle,
        ExtensionFilter[] filters,
        string defaultDirectory,
        bool multibleFiles
    )
    {
        System.Console.WriteLine(string.Join('|', filters.Select(f => f.Filter)));
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Multiselect = multibleFiles;
        dialog.Filter = string.Join('|', filters.Select(f => f.Filter));
        dialog.Title = windowTitle;
        dialog.DefaultDirectory = defaultDirectory;
        if (dialog.ShowDialog() == true)
        {
            return dialog.FileNames;
        }
        return [];
    }

    public static string? AskOpenFolder(
        string? windowTitle = null,
        ExtensionFilter[]? filters = null,
        string? defaultDirectory = null
    )
    {
        var ret = AskOpenFolder(
            windowTitle ?? "Select a file",
            filters ?? Array.Empty<ExtensionFilter>(),
            defaultDirectory: defaultDirectory ?? "",
            multibleFiles: false
        );
        if (ret.Length >= 1)
        {
            return ret[0];
        }
        return null;
    }

    public static string[] AskOpenFolders(
        string? windowTitle = null,
        ExtensionFilter[]? filters = null,
        string? defaultDirectory = null
    )
    {
        return AskOpenFolder(
            windowTitle ?? "Select a file",
            filters ?? Array.Empty<ExtensionFilter>(),
            defaultDirectory: defaultDirectory ?? "",
            multibleFiles: true
        );
    }

    private static string[] AskOpenFolder(
        string windowTitle,
        ExtensionFilter[] filters,
        string defaultDirectory,
        bool multibleFiles
    )
    {
        System.Console.WriteLine(string.Join('|', filters.Select(f => f.Filter)));
        OpenFolderDialog dialog = new OpenFolderDialog();
        dialog.Multiselect = multibleFiles;
        dialog.Title = windowTitle;
        dialog.DefaultDirectory = defaultDirectory;
        if (dialog.ShowDialog() == true)
        {
            return dialog.FolderNames;
        }
        return [];
    }
}
