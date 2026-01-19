using System;

public class Program
{
    private static int unusedField;

    public static void Main(string[] args)
    {
        Console.WriteLine(Test(1,2,3,4,5,6,7,8));
    }

    private static string Test(int a,int b,int c,int d,int e,int f,int g,int h)
    {
        string s = "Hello";
        string t = s;

        if (true) { }

        try
        {
        }
        catch (Exception)
        {
        }

        if (s == s)
        {
            s = s;
        }

        if (false)
        {
            s = "never";
        }

        return t;
    }
}
