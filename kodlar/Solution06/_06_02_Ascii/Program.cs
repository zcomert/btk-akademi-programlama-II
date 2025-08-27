// OTP

// ASCII 65 - 90 (A-Z)
Random rnd = new Random();
string userCode = "";

Console.WriteLine("ASCII Karakteri (A-Z)");
for (int code = 65; code <= 90; code++)
{
    char letter = (char)code;
    Console.Write(letter + " ");
}

Console.WriteLine("\n");

// 6 haneli bir kullanıcı kodu
for (int i = 0; i < 6; i++)
{
    int ascii = rnd.Next(65,91); // 65 - 90 rastgele bir sayı
    char randomLetter = (char)ascii;
    userCode += randomLetter; // String ile birleştir
}

Console.WriteLine($"Oluşturulan kullanıcı kodu: {userCode}");
Console.ReadKey();

