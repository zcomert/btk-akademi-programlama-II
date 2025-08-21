public class BinarySearch : SearchAlgorithm
{
    public BinarySearch(params int[] numbers) 
        : base(numbers)
    {
        
    }

    public override int Search(int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (numbers[mid] == target)
                return mid;
            else if (numbers[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
