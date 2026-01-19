using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetMessage(args));
    }

    private static string GetMessage(string[] args)
    {
        string msg = "Hello, World!";
        string tmp = msg;

        int magic = 42;
        if (magic == 42) { }

        try
        {
        }
        catch (Exception)
        {
        }

        if (args != null && args.Length > 0 && args[0] != null && args[0].Length > 0)
        {
            msg = args[0];
        }

        if (msg == msg)
        {
            msg = msg;
        }

        if (false)
        {
            msg = "never";
        }

        return tmp;
    }
}



