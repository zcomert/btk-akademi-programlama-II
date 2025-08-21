using System;


public class LogFile : FileHandler
{
    public LogFile(string filePath) : base(filePath)
    {

    }

    // Log ekleme
    public void AppendLog(String logMessage)
    {
        using (StreamWriter sw = File.AppendText(FilePath))
        {
            sw.WriteLine($"{DateTime.Now} : {logMessage}");
        }
        System.Console.WriteLine("Log dosyaya eklendi.");
    }
}
