// Değer tip 

int num1 = 10;
int num2 = 20;

Console.WriteLine($"Metot çağrısı öncesi num1={num1} ve num2={num2}");
SwapNumbers(num1, num2);
Console.WriteLine($"Metot çağrısı sonrası num1={num1} ve num2={num2}");

// Referans tip
int[] numbers = { 10, 20 };
Console.WriteLine($"Metot çağrısı öncesi num1={numbers[0]} ve num2={numbers[1]}");
SwapArray(numbers);
Console.WriteLine($"Metot çağrısı sonrası num1={numbers[0]} ve num2={numbers[1]}");

static void SwapArray(int[] numbers)
{
    int temp = numbers[0];
    numbers[0] = numbers[1];
    numbers[1] = temp;
}

static void SwapNumbers(int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
}

Console.ReadKey();