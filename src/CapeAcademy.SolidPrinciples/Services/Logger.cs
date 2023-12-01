namespace CapeAcademy.SolidPrinciples.Services;

public class Logger
{
    public void LogMessage(string format, params object?[] args)
    {
        Console.WriteLine(format, args);
    }
}