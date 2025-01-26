
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

First create a new Csharp project. Take the .dll file and place it into your Project folder. If you place it else where, you need to change the HintPath. Go into the .csproj file and make shure it looks similar to this. Important are the **TargetFramework**, the **UseWPF** and the **ItemGroup**
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0-windows</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <UseWPF>true</UseWPF>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="CsTkinter">
      <HintPath>./CsTkinter.dll</HintPath>
    </Reference>
  </ItemGroup>

</Project>
```
Now crate a class with a Main function. It needs the **STAThread** attribute. Here is a sample application.
```csharp
using CsTkinter.Widgets;
using CsTkinter.Windows;

class App
{
    [STAThread]
    static void Main(string[] args)
    {
        CtWindow root = new();

        CtLabel label = new CtLabel(root);
        label.Place(10, 10);

        root.Run();
    }
}
```
If you have trouble because of the dependency, try run dotnet clean.
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
