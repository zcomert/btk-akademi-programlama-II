// dizi tanımı
int[] numbers = new int[5];

// değer atama
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

System.Console.WriteLine("Dizi elemanları");

for (int i = 0; i < numbers.Length; i++)
{
    System.Console.WriteLine($"{i}. indis değerindeki değer: {numbers[i]}");
}

System.Console.WriteLine("Dizi elemanları (ters sırada)");

for (int i = numbers.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine($"{i}. indis değerindeki değer: {numbers[i]}");
}

Console.ReadKey();