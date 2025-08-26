// See https://aka.ms/new-console-template for more information
class Student
{
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; }
    public String Name { get; set; }

    public override string ToString() => $"{Id} {Name}";
    
}

