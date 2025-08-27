namespace Log;

public class SecureFileLogger : FileLogger
{
    public SecureFileLogger(string message, string path)
        : base(message, path)
    {

    }

    public override void Log()
    {
        char[] chars = logMessage.ToCharArray();
        Array.Reverse(chars);
        string encrypted = new string(chars);

        File.AppendAllText(filePath, encrypted + Environment.NewLine);
        System.Console.WriteLine($"Şifrelenmiş log yazıldı: {filePath}");
    }
}
