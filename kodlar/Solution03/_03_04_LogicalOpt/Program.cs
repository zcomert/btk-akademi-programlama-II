Console.WriteLine("Yaşınızı giriniz: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sağlık raporunuz var mı? (evet/hayır)");

string reportInput = Console.ReadLine().ToLower();
bool hasHealthReport = reportInput == "evet";

if (age>=18 && hasHealthReport)
    Console.WriteLine("Ehliyet alabilirsiniz.");
else
    Console.WriteLine("Ehliyet alma şartlarını sağlamıyorsunuz!");

if (age>=18 || hasHealthReport)
{
    Console.WriteLine("Koşullardan en az biri sağlanıyor.");
}
else
{
    Console.WriteLine("Koşullardan hiçbirini sağlamıyorsunuz.");
}