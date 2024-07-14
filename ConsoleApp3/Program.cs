using System;

public delegate void Func(string str);

public class MyClass
{
    private string input;

    public MyClass(string str)
    {
        input = str;
    }

    public void Space(string str)
    {
        string spaced = string.Join("_", str.ToCharArray());
        Console.WriteLine($"Space: {spaced}");
    }

    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine($"Reverse: {reversed}");
    }
}

public class Run
{
    public void runFunc(Func funcDell, string str)
    {
        funcDell(str);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string:");
        var str = Console.ReadLine();

        MyClass cls = new MyClass(str);

        Func funcDell = new Func(cls.Space);
        funcDell += new Func(cls.Reverse);

        Run run = new Run();
        run.runFunc(funcDell, str);
    }
}
