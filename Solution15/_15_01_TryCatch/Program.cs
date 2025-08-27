try
{
    int a = 10;
    int b = 0;

    var result = a / b;
}
catch(FileNotFoundException f)
{
    throw new FileNotFoundException(f.Message);
}
catch(DivideByZeroException z)
{
    throw new DivideByZeroException("Sıfıra bolme hatası");
}
catch(Exception ex)
{ 
    throw new Exception($"Bir hata oluştu: {ex.Message}");
}
finally
{
    Console.WriteLine("Program sona eriyor...");
}

Console.ReadKey();
