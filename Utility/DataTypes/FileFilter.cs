using System;

namespace CsTkinter.Utility.DataTypes;

public readonly struct ExtensionFilter
{
    public readonly string Filter;
    public ExtensionFilter(string name, string[] extensions)
    {
        extensions = extensions
            .Select(ext => ext.StartsWith('.') ? ext : '.' + ext)
            .Select(ext => '*' + ext)
            .ToArray();
        Filter = name + '|' + string.Join(";", extensions);
    }
}
