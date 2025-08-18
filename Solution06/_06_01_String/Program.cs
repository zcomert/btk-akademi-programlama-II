// String tanımlama
string message = "Merhaba";
Console.WriteLine("İlk mesaj:" + message);

// immutable
//message[0] = 'd';
string newMessage = message + " Dünya";
Console.WriteLine("Yeni mesaj : " + newMessage);
Console.WriteLine("Eski mesaj : " + message);

// Dizi benzer işlemler 
Console.WriteLine("İlk karakter: " + message[0]);
Console.WriteLine("İlk karakter: " + message[message.Length-1]);


// Döngüler 
Console.WriteLine("\nTüm Karakterler");
foreach (char c in message)
{
    Console.WriteLine(c);
}

// String metotları
Console.WriteLine("Karakter sayısı : " + message.Length);
Console.WriteLine("Büyük harf: " + message.ToUpper());
Console.WriteLine("Dünya içeriyor mu?" + message.Contains("Dünya"));

Console.ReadKey();
