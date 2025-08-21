using System;

public class FileHandler
{
    public String FilePath { get; set; }

    public FileHandler(string filePath)
    {
        FilePath = filePath;
    }

    public void WriteToFile(String content)
    {
        File.WriteAllText(FilePath, content);
        System.Console.WriteLine("Dosya yazma işlemi başarılı.");
    }

    public String ReadFromFile()
    {
        if (File.Exists(FilePath))
        {
            return File.ReadAllText(FilePath);
        }
        else
        {
            return "Dosya bulunamadı.";
        }
    }
}
