int? age = 22;           // int tipi
var name = "Ali";       // string tipi 

Console.WriteLine("age değişkenin tipi : " + age?.GetType());
Console.WriteLine("name değişkenin türü :" + name.GetType());

string? nullable = null;     // nullable string
Console.WriteLine("Büyük harf : " + nullable?.ToUpper());
Console.WriteLine("Kullanıcı adı : " + (nullable ?? "Bilinmiyor"));
Console.WriteLine("Yaş : " + (age ?? -1));

Console.ReadKey();