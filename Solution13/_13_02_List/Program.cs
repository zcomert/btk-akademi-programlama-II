var numbers = new List<int>()
{
    10,20,30,40,50,60
};

numbers.Add(-5);
numbers.AddRange(new int[] { -5, -3, 5, 101, 15 });

int sum = 0;

foreach (int number in numbers)
{
    sum += number;
    Console.WriteLine(number);
}

Console.WriteLine($"Toplam  {sum}");

Console.ReadKey();