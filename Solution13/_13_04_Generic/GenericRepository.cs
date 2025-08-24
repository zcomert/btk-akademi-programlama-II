public class GenericRepository<T>
{
    private readonly List<T> items;
    public GenericRepository()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintWithMessage<U>(U message)
    {
        Console.WriteLine("Mesaj :" + message);
        PrintAll();
    }
}