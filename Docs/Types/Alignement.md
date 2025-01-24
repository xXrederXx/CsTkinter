# Alignment

This is a struct, which is used to define the alignement of an element. You wil need to use enums from WPF. <a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.horizontalalignment?view=windowsdesktop-9.0">HorizontalAlignment</a> and <a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.verticalalignment?view=windowsdesktop-9.0">VerticalAlignment</a>

<p align="left">
  <a href="#example-code">Example Code</a> •
  <a href="#arguments">Arguments</a> •
  <a href="#variables">Variables</a> 
</p>

## Example Code

```csharp
    Alignment alignment = new Alignment(
        HorizontalAlignment.Right,
        VerticalAlignment.Top;
    )
```

## Arguments

| Argument | Type | Description |
|----------|------|-------------|
|horizontal|HorizontalAlignment| alignement on the horizontal axis|
|vertical|VerticalAlignment| alignement on the vertical axis|


## Variables

All variables are readonly

| Name     | Type | Description |
|----------|------|-------------|
|horizontal|HorizontalAlignment| alignement on the horizontal axis|
|vertical|VerticalAlignment| alignement on the vertical axis|

