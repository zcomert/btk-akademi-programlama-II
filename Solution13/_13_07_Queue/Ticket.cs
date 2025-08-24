class Ticket
{
    public int Id { get;  }
    public Customer Customer { get;  }
    public String Topic { get;  }
    public DateTime CreatedAt { get; }

    public Ticket(int id, Customer customer, 
        string topic)
    {
        Id = id;
        Customer = customer;
        Topic = topic;
        CreatedAt = DateTime.Now;
    }

    public void Process()
    {
        Console.WriteLine($"İşleniyor -> #{Id, -5} | " +
            $"{Customer.FullName,-20} | " +
            $"{Topic}");
    }

    public override string ToString() => $"#{Id,-5} - " +
        $"{Customer.FullName,-20} - {Topic,-20} - {CreatedAt:HH:mm:ss}";
    
}
