LogFile logFile = new LogFile("log.txt");

// üst sınıf (base) özellikleri
logFile.WriteToFile("Başlangıç log kaydı");
System.Console.WriteLine("Dosya içeriği:");
Console.Write(logFile.ReadFromFile());

// alt sınıf özellikleri
logFile.AppendLog("Kullanıcı sisteme giriş yaptı.");
logFile.AppendLog("Veri güncelleme işlemi gerçekleştirildi.");

System.Console.WriteLine("Son dosya içeriği:");
System.Console.WriteLine(logFile.ReadFromFile());

Console.ReadKey();