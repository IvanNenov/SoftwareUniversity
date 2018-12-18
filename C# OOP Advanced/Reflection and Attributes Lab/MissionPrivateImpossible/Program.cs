using System;

class Program
{
    static void Main(string[] args)
    {
        Spy spy = new Spy();
        var className = typeof(Hacker).Name;
        string result = spy.RevealPrivateMethods(className);
        Console.WriteLine(result);
    }
}