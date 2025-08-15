// Kur bilgileri ve tarih
var dollarRate = 40.70m;
decimal euroRate = 47.50m;
decimal goldRate = 4400m;
DateTime rateDate = DateTime.Now;

Console.WriteLine("TL miktarını giriniz: ");
decimal amountInTL = Convert.ToDecimal(Console.ReadLine());

// Menü 
Console.WriteLine("\nDönüştürme Seçenekleri");
Console.WriteLine("1- Dolar");
Console.WriteLine("2- Euro");
Console.WriteLine("3- Altın (gram)");

Console.WriteLine("\nSeçiminizi yapınız (1-3). ");
int choice = Convert.ToInt32(Console.ReadLine());

decimal result = 0m;
string currenyName = "";

switch (choice)
{
	case 1:
		result = amountInTL / dollarRate;
		currenyName = "USD";
		break;
	case 2:
		result = amountInTL / euroRate;
		currenyName = "EUR";
		break;
	case 3:
		result = amountInTL / goldRate;
		currenyName = "Gram Altın";
		break;
	default:
		Console.WriteLine("Geçersiz giriş!");
		return;
}


Console.WriteLine($"\nTarih: {rateDate} ");
Console.WriteLine($"Girilen TL miktarı: {amountInTL} TL");
Console.WriteLine($"Dönüşüm sonucu: {result:F2} {currenyName}");
Console.WriteLine("\n---Kurlar---");
Console.WriteLine($"Dolar: {dollarRate} TL");
Console.WriteLine($"Euro: {euroRate} TL");
Console.WriteLine($"Altın: {goldRate} TL");

//Console.WriteLine(dollarRate.GetType());
Console.ReadKey();