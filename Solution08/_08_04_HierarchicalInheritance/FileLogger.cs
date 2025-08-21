namespace Log;

public class FileLogger : Logger
{
    protected String filePath;
    public FileLogger(string message)
        : this(message, "log.txt")
    {

    }
    public FileLogger(string message, string path)
        : base(message)
    {
        filePath = path;
    }

    public override void Log()
    {
        File.AppendAllText(filePath, logMessage + Environment.NewLine);
        System.Console.WriteLine("Log dosyaya yazıldı: " + filePath);
    }
}