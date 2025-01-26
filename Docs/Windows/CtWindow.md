# CtWindow

This is the base of every app. You may only use one instance. To launch the app just run the function Run() once. It is important to use the STAThread attribute on the function you are running the app.

<p align="left">
  <a href="#example-code">Example Code</a> •
  <a href="#methods">Methods</a> •
  <a href="#variables">Variables</a> •
  <a href="#todo">TODO</a>
</p>

## Example Code

```csharp
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            CtWindow app = new CtWindow();
            app.Geometry = new Vector2(200, 200);

            CtLabel label = new CtLabel(app, text: "Nice Label");
            lable.Place(100, 100);

            app.Run();
        }
    }
```

## Arguments

| Argument  | Type        | Default                          | Description                                 |
| --------- | ----------- | -------------------------------- | ------------------------------------------- |
| title     | string      | "CsTkinter App"                  | The title of the window, displayed top left |
| geometry  | Vector2     | (600, 500)                       | the standart width and height               |
| minSize   | Vector2     | (10, 10)                         | the minimum width and height                |
| maxSize   | Vector2     | (float.MaxValue, float.MaxValue) | the maximum width and height                |
| resizable | bool        | true                             | Is the window resizable?                    |
| state     | WindowState | WindowState.Normal               | State of the window                         |

## Methods

| Method                                            | Description                                 |
| ------------------------------------------------- | ------------------------------------------- |
| void Run()                                        | launches the App, you may only call it once |
| void Place(UIElement element, double x, double y) | this function should not be used directly   |

## Variables

| Name      | Type        | Description                                      |
| --------- | ----------- | ------------------------------------------------ |
| Title     | string      | Window title                                     |
| Geometry  | Vector2     | The size of the window                           |
| MinSize   | Vector2     | The minimal size of the window                   |
| MaxSize   | Vector2     | The maximal size of the window                   |
| Resizable | bool        | Is the window rezisable?                         |
| State     | WindowState | state of the window - maximised, minimized, etc. |

## TODO
 - [x] Better inizalizer
 - [ ] More Functionality
  
---
26.1.2025