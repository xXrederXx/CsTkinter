# FontType

FontType is a struct, which is used for defining a Font. it holds data about the Font Family, Size, Style, Weight and Strech. For some arguments you need to use the FontStyles, FontWeights and FontStretches classes.

<p align="left">
  <a href="#example-code">Example Code</a> •
  <a href="#arguments">Arguments</a> •
  <a href="#methods">Methods</a> •
  <a href="#variables">Variables</a> •
  <a href="#todo">TODO</a>
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

| Argument | Type | Description |
|----------|------|-------------|
|fontFamily|FontFamily| describes the Font Family|
|fontSize|double| describes the Font size|
|fontStyle|FontStyle| describes the Font Style - bold, italic, etc|
|fontWeight|FontWeight|describes the Font Weight - Thin, Bold, etc|
|fontStretch|FontStretch| describes the Font Strech - Expanded, Condensed, etc|

## Methods

There are no public methods

## Variables
All are readonly

| Name     | Type | Description |
|----------|------|-------------|
|fontFamily|FontFamily| describes the Font Family|
|fontSize|double| describes the Font size|
|fontStyle|FontStyle| describes the Font Style - bold, italic, etc|
|fontWeight|FontWeight|describes the Font Weight - Thin, Bold, etc|
|fontStretch|FontStretch| describes the Font Strech - Expanded, Condensed, etc|

## TODO
 - [x] No Todo