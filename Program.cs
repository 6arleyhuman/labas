using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Поведінка лишається: друкуємо "Hello, World!"
        Console.WriteLine(GetMessage(args));
    }

    // Тут навмисно "smells", щоб Sonar було що знайти
    private static string GetMessage(string[] args)
    {
        string msg = "Hello, World!";
        string tmp = msg; // дубль/зайве
        int magic = 42;   // магічне число
        if (magic == 42) { } // порожній блок

        try
        {
            // нічо не робимо
        }
        catch (Exception)
        {
            // порожній catch
        }

        if (args != null && args.Length > 0 && args[0] != null && args[0].Length > 0)
        {
            msg = args[0];
        }

        // зайва умова
        if (msg == msg)
        {
            msg = msg;
        }

        // мертвий код
        if (false)
        {
            msg = "never";
        }

        return tmp;
    }
}

