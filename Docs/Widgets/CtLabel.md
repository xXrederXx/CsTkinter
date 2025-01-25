# CtLabel

CtLabel is used to create a Label in a window. It has great flexability.

<p align="left">
  <a href="#example-code">Example Code</a> •
  <a href="#arguments">Arguments</a> •
  <a href="#variables">Variables</a> •
  <a href="#todo">TODO</a>
</p>

## Example Code

```csharp
    CtWindow root = new CtWindow();
    CtLabel Label = new CtLabel(root, text: "A cool Label");
    Label.Width = 200;
    Label.Place(10, 10);
```

## Arguments

| Argument | Type    | Default   | Description                                |
| -------- | ------- | --------- | ------------------------------------------ |
| master   | IWindow | -         | The Window the element should be placed in |
| width    | double  | 100       | Width of the element                       |
| height   | double  | 24        | Height of the element                      |
| text     | string  | "CtLabel" | Text to display                            |


## Variables


| Name         | Type                                           | Description                       |
| ------------ | ---------------------------------------------- | --------------------------------- |
| Width        | double                                         | Defines the width of the element  |
| Height       | double                                         | Defines the hight of the element  |
| Text         | string                                         | The displayed texed               |
| CornerRadius | CornerRadius                                   | The corner radiuses               |
| FgColor      | Brush                                          | The text color                    |
| BgColor      | Brush                                          | The background color              |
| Font         | <a href="../Types/FontType.md">FontType</a>    | The font used for the text        |
| BorderColor  | Brush                                          | The border color                  |
| BorderWidth  | Thickness                                      | The border width                  |
| JustifyText  | <a href="../Types/Alignement.md">Alignment</a> | Defines where the text is aligned |

## TODO
 - [ ] Better Initalizer

---
25.1.2025