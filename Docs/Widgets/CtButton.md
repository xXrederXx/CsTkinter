# CtButton

CtButton is used to create a button. It suports multiple colors for hover and click. You can run functions on click and do much more.

<p align="left">
  <a href="#example-code">Example Code</a> •
  <a href="#arguments">Arguments</a> •
  <a href="#variables">Variables</a> •
  <a href="#todo">TODO</a>
</p>

## Example Code

```csharp
    CtWindow root = new CtWindow();
    CtButton Button = new CtLabel(root);
    Button.Width = 200;
    Button.HoverFgColor = BrushConverter.FromColor(255, 100, 100);
    Button.Place(10, 10);
```

## Arguments

| Argument | Type    | Default    | Description                                |
| -------- | ------- | ---------- | ------------------------------------------ |
| master   | IWindow | -          | The Window the element should be placed in |
| width    | double  | 100        | Width of the element                       |
| height   | double  | 24         | Height of the element                      |
| text     | string  | "CtButton" | Text on the button                         |


## Variables

| Name             | Type                                           | Description                                            |
| ---------------- | ---------------------------------------------- | ------------------------------------------------------ |
| Width            | double                                         | Defines the width of the element                       |
| Height           | double                                         | Defines the hight of the element                       |
| Text             | string                                         | The text on the button                                 |
| FgColor          | Brush                                          | The text color                                         |
| BgColor          | Brush                                          | The background color                                   |
| BorderColor      | Brush                                          | The border color                                       |
| HoverFgColor     | Brush                                          | The text color while the mous is over the button       |
| HoverBgColor     | Brush                                          | The background color while the mous is over the button |
| HoverBorderColor | Brush                                          | The border color while the mous is over the button     |
| ClickFgColor     | Brush                                          | The text color while the mouse is clicking             |
| ClickBgColor     | Brush                                          | The background color while the mouse is clicking       |
| ClickBorderColor | Brush                                          | The border color while the mouse is clicking           |
| Font             | <a href="../Types/FontType.md">FontType</a>    | The font used for the text                             |
| BorderWidth      | Thickness                                      | The border width                                       |
| JustifyText      | <a href="../Types/Alignement.md">Alignment</a> | Defines where the text is aligned                      |
| OnClick          | Action                                         | Gets called everytime the user clickes the button      |

## TODO
 - [ ] Fix Bug on startup
 - [ ] Better Inizalizor


---
25.1.2025