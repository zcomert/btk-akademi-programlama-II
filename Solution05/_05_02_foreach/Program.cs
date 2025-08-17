// tanim - başlangıç 
int[] numbers = { 10, 20, 30, 40, 50 };

// toplam
int sum = 0;

// foreach döngüsü ile her bir elemanı dolaş
foreach (var number in numbers)
{
    // her adımda ekleme yap.
    sum += number;
}

// ortalama hesabı
double average = (double)sum / numbers.Length;

// Sonuç yazdır
System.Console.WriteLine($"Ortalama: {average:F2}");

Console.ReadKey();

