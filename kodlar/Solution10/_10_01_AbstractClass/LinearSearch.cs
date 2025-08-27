public class LinearSearch : SearchAlgorithm
{
    public LinearSearch(params int[] numbers) 
        : base(numbers)
    {
        
    }
    public override int Search(int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
                return i;
        }
        return -1;
    }
}