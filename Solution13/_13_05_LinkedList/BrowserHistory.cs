using System.Security;

class BrowserHistory
{
    private readonly LinkedList<string> history;
    private LinkedListNode<string> current;
    public BrowserHistory()
    {
        history = new LinkedList<string>();
    }
    public void VisitPage(string url)
    {
        if (current == null)
        {
            current = history.AddFirst(url);
        }
        else
        {
            while (current.Next!= null)
                history.Remove(current.Next);
            current = history.AddAfter(current,url);
        }
        Console.WriteLine($"Ziyaret:{url}");
    }

    public void Back()
    {
        if(current?.Previous is not null)
        {
            current = current.Previous;
            Console.WriteLine($"Geri: {current.Value}");
        }
        else
        {
            Console.WriteLine("Geçmişte veri yok!");
        }
    }

    public void Forward()
    {
        if (current?.Next is not null)
        {
            current = current.Next;
            Console.WriteLine($"İleri: {current.Value}");
        }
        else
        {
            Console.WriteLine("İleride başka sayfa yok.");
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("=== Tüm Geçmiş ===");
        for (var node = history.First; node!= null; node = node.Next)
        {
            var marker = node == current ? " <= current" : "";
            Console.WriteLine($"{node.Value} {marker}");
        }
    }
}
