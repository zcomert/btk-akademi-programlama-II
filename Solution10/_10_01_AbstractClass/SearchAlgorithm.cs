// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

public abstract class SearchAlgorithm
{
    protected int[] numbers;
    public SearchAlgorithm(params int[] numbers)
    {
        this.numbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            this.numbers[i] = numbers[i];
        }
    }

    public abstract int Search(int target);
    protected void PrintMessage(string message)
    {
        System.Console.WriteLine(message);
    }

    public void PrintResult(int index, int target)
    {
        if (index == -1)
            PrintMessage($"{target} bulunamadı.");
        else
            PrintMessage($"{target} {index}. indekste bulundu.");
    }
}
