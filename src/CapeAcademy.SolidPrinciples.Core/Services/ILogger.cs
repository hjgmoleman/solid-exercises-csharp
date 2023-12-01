namespace CapeAcademy.SolidPrinciples.Services;

public interface ILogger
{
    void LogMessage(string format, params object?[] args);
}