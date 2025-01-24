
<h1 align="center">
  <br>
  <img src="./Media/Logo.png" alt="Markdownify" width="300">
  <br>
  CsTkinter
  <br>
</h1>

<h4 align="center">A C# version based of <a href="https://docs.python.org/3/library/tkinter.html" target="_blank">Tkinter</a> and <a href="https://customtkinter.tomschimansky.com/" target="_blank">Customtkinter</a>.</h4>


<p align="center">
  <a href="#key-features">Key Features</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#TODO">TODO</a> •
  <a href="#license">License</a>
</p>

## Key Features

* Easy to use
* Tkinter like behavior
* Only Code, no xaml  
* Based of Performant WPF
* Spacial Features

## How To Use

First create a new Csharp project. Go into the .csproj file and make shure it looks similar to this. Important are the **TargetFramework** and the **UseWPF**
```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0-windows</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <UseWPF>true</UseWPF>
  </PropertyGroup>
</Project>
```
Then import all the scripts. Now you should be able to create an application.
This is a sample app with only a lable. Importent is the **STAThread** attribute.
```csharp
class Program
{
    [STAThread] // Required for WPF
    static void Main(string[] args)
    {
        Console.WriteLine("Launching WPF Window...");

        // Start the WPF application
        CtWindow app = new CtWindow();
        app.Geometry = new Vector2(200, 200);

        CtLabel lable = new CtLabel(app, text: "Nice Label");
        lable.Place(100, 100);

        app.Run();

        Console.WriteLine("WPF Window closed.");
    }
}

```
Now try to build your own app.

## TODO
- [ ] Add more Widgets
- [ ] Add more Place methods
- [ ] Add general functionality


## You may also like...

- [Y-Sharp](https://github.com/xXrederXx/YSharp) - My custom language
- [Wiki Word Plotter](https://github.com/xXrederXx/WikiWordPlotter) - A tool to plot words from Wikipedia

## License

 [GNU GPLv3](./LICENSE)

---
