# FontType

FontType is a struct, which is used for defining a Font. it holds data about the Font Family, Size, Style, Weight and Strech. For some arguments you need to use WPF classes  <a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.fontfamily?view=windowsdesktop-9.0">FontFamily</a>, <a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.fontstyles?view=windowsdesktop-9.0">FontStyles</a>, <a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.fontweights?view=windowsdesktop-9.0">FontWeights</a> and <a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.fontstretches?view=windowsdesktop-9.0">FontStretches</a> classes.

<p align="left">
  <a href="#example-code">Example Code</a> •
  <a href="#arguments">Arguments</a> •
  <a href="#variables">Variables</a> 
</p>

## Example Code

```csharp
    FontType font = new FontType(
        new FontFamily("Helvetica"),
        24,
        FontStyles.Normal,
        FontWeights.Bold,
        FontStretches.Condensed
    )
```

## Arguments

| Argument    | Type        | Default              | Description                                          |
| ----------- | ----------- | -------------------- | ---------------------------------------------------- |
| fontFamily  | FontFamily  | -                    | describes the Font Family                            |
| fontSize    | double      | 11                   | describes the Font size                              |
| fontStyle   | FontStyle   | FontStyles.Normal    | describes the Font Style - bold, italic, etc         |
| fontWeight  | FontWeight  | FontWeights.Normal   | describes the Font Weight - Thin, Bold, etc          |
| fontStretch | FontStretch | FontStretches.Normal | describes the Font Strech - Expanded, Condensed, etc |


## Variables
All are readonly

| Name        | Type        | Description                                          |
| ----------- | ----------- | ---------------------------------------------------- |
| fontFamily  | FontFamily  | describes the Font Family                            |
| fontSize    | double      | describes the Font size                              |
| fontStyle   | FontStyle   | describes the Font Style - bold, italic, etc         |
| fontWeight  | FontWeight  | describes the Font Weight - Thin, Bold, etc          |
| fontStretch | FontStretch | describes the Font Strech - Expanded, Condensed, etc |

---
25.1.2025