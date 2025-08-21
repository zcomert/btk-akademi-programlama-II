using System;

namespace Log;

public class Logger
{
    protected String logMessage;

    public Logger(String message)
    {
        logMessage = message;
    }

    public virtual void Log()
    {
        System.Console.WriteLine($"Log Mesajı: {logMessage}");
    }
}
