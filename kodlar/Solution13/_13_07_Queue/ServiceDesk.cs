class ServiceDesk
{
    private readonly Queue<Ticket> queue;
    public int Count => queue.Count;
    public ServiceDesk()
    {
        queue = new Queue<Ticket>();
    }

    public void Enqueue(Ticket ticket)
    {
        queue.Enqueue(ticket);
        Console.WriteLine($"Kuyruğa alındı: {ticket}");
    }

    public void PeekNext()
    {
        if (queue.Count==0)
        {
            Console.WriteLine($"Kuyruk boş!");
            return;
        }
        Console.WriteLine($"Sıradaki: {queue.Peek()}");
    }

    public void ProcessNext()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("İşlenecek bilet yok!");
            return;
        }
        var ticket = queue.Dequeue();
        ticket.Process();
    }

    public void PrintQueue()
    {
        Console.WriteLine();
        Console.WriteLine("=== Kuyruk ===");
        if(queue.Count==0)
        {
            Console.WriteLine("Kuyruk boş!");
            return;
        }
        foreach (var ticket in queue)
        {
            Console.WriteLine(ticket);
        }
        Console.WriteLine("");
    }
}