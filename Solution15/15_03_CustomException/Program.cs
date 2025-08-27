using Errors;


try
{
    Console.WriteLine("Yaşınızı giriniz: ");
    int age = int.Parse(Console.ReadLine());

    if (age < 0 || age > 120)
    {
        //throw new InvalidAgeException("Yaş 0 ve 120 arasında olmalıdır!");
        throw new InvalidAgeException();
    }
    Console.WriteLine($"Geçerli yaş: {age}");
}
catch(InvalidAgeException ex)
{
    Console.WriteLine($"Hata: {ex.Message}" );
}
catch(Exception ex)
{
    Console.WriteLine($"Beklenmeyen hata: {ex.Message}");
}

Console.ReadKey();
