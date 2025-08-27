internal class City
{
    public City(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get;  }
    public String Name { get; }

    public override string ToString() =>
        $"{Id,-5} {Name,-20}";
}
