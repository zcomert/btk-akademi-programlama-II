internal class Student
{
    public int Id { get; }
    public String Name { get; }
    public Student()
    {
        Id = 0;
        Name = String.Empty;
    }

    public Student(int id, string name)
    {
        Id = id;
        Name = name ?? "Bilinmiyor";
    }

    public override string ToString() =>
        $"Id: {Id,-5} Name: {Name,-20}";
     
}
