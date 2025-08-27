using Errors;
using Models;

try
{
    Console.WriteLine("İsmi giriniz: ");
    string name = Console.ReadLine();

    Console.WriteLine("Yaşınızı giriniz: ");
    int age = int.Parse(Console.ReadLine());

    var person = new Person(age, name);
    person.PrintInfo();

    Console.ReadKey();
}
catch(InvalidAgeException ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Beklenmeyen hata: " + ex.Message);
}
finally
{
    Console.WriteLine("Program sonlandı.");
}