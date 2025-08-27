using CoreLib;

Console.WriteLine("===Erişim Belirteçleri===");
var access = new AccessShowcase();

Console.WriteLine($"Public: {access.PublicInfo}");
Console.WriteLine($"Private (sınıf içinde): {access.ReadPrivateInside()}");

//Console.WriteLine(access.InternalInfo);
//Console.WriteLine(access.ProtectedInfo);

Console.WriteLine();

var phone = new DerivedPhone();
Console.WriteLine($"Şarj seviyesi : {phone.GetBattery()}");
phone.Use();
Console.WriteLine($"Kullanım sonrası şarj seviyesi : {phone.GetBattery()}");

var facade = new InternalUtilityFacade();
Console.WriteLine($"Facade aracılığıyla : {facade.UseInternal()}");
Console.WriteLine("Program tamamlandı.");

Console.ReadKey();