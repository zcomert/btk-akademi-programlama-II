try
{
    Console.WriteLine("Bir sayı giriniz: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bölen giriniz: ");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int result = Divide(number, divisor);
    Console.WriteLine($"Sonuç: {result}");
    Console.ReadKey();
}
catch(FormatException)
{
    Console.WriteLine("Geçerli bir sayı giriniz.");
}
catch(DivideByZeroException)
{
    Console.WriteLine($"Sıfıra bölünemez!");
}
catch(Exception ex)
{
    Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
}
finally
{
    Console.WriteLine("Program sona eriyor.");
}

int Divide(int a, int b)
{
    if (b.Equals(0))
        throw new DivideByZeroException("Bölen sıfır olamaz!");
    return a / b;
}