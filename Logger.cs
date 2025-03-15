namespace Anemone;

public class Logger
{
    public static void Debug(string message)
    {
        Console.Write(" ");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write("Debug");

        Console.ResetColor();
        Console.Write(" ");

        Console.Write(message);
        Console.Write("\n");
    }

    public static void Warn(string message)
    {
        Console.Write(" ");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write("Warn");

        Console.ResetColor();
        Console.Write(" ");

        Console.Write(message);
        Console.Write("\n");
    }

    public static void Error(string message)
    {
        Console.Write(" ");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("Error");

        Console.ResetColor();
        Console.Write(" ");

        Console.Write(message);
        Console.Write("\n");
    }

    public static void Fatal(string message)
    {
        Console.Write(" ");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.Write("Fatal");

        Console.ResetColor();
        Console.Write(" ");

        Console.Write(message);
        Console.Write("\n");
    }
}