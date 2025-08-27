Console.WriteLine("Adınızı giriniz");
string firstName = Console.ReadLine();

Console.WriteLine("Soyadınızı giriniz: ");
string lastName = Console.ReadLine();

// + operatörü
string welcome1 = "Merhaba " + firstName + " " + lastName + " , sisteme hoşgeldiniz.";

// Concat
string welcome2 = String.Concat("Sayın ", 
            firstName, " ", 
            lastName, " , " +
            "girişiniz başarı ile gerçekleştirdiniz.");

// Interpolasyon
string welcome3 = $"Hoş geldiniz {firstName} {lastName?.ToUpper()} {DateTime.Now:dd.MM.yyyy}.";

Console.WriteLine(welcome1);
Console.WriteLine(welcome2);
Console.WriteLine(welcome3);

Console.ReadKey();