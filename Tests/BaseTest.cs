using System;
using System.Numerics;
using CsTkinter.Utility;

namespace CsTkinter.Tests;

public class BaseTest
{
    protected CtWindow app;
    private readonly string TestId;

    public BaseTest(string testId)
    {
        TestId = testId;
        Console.WriteLine("Launching Test Window Id: " + TestId);

        app = new CtWindow();

        InitTest();

        app.Run();

        Console.WriteLine($"WPF Window Id: {TestId} closed.");
    }

    public virtual void InitTest()
    {
        System.Console.WriteLine("No InitTest defined for Window Id: " + TestId);
    }
}
