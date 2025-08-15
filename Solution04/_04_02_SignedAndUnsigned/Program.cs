// İşaretsiz byte
Console.WriteLine("İşaretsiz byte (0 - 255)");
Console.WriteLine($"Min değer: {byte.MinValue}, Max değer: {byte.MaxValue}");

Console.WriteLine("sbyte (-128 - 127)");
Console.WriteLine($"Min değer: {sbyte.MinValue}, Max değer: {sbyte.MaxValue}");

// İşaretsiz değerlerde wrap-around 
Console.WriteLine("");
byte unsignedValue = 255;
Console.WriteLine($"Başlangıç değeri : {unsignedValue}");
unsignedValue++; // 255 + 1 -> 256 (x) - 0
Console.WriteLine($"Taşma sonrası değer: {unsignedValue}");

// İkili gösterim (binary)
Console.WriteLine("Binary karşılıklar");
Console.WriteLine($"Byte 255 : {Convert.ToString(255,2)}");
Console.WriteLine($"Byte  15 : {Convert.ToString(15,2).PadLeft(8,'0')}");


Console.ReadKey();