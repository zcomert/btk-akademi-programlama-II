// See https://aka.ms/new-console-template for more information
class Student
{
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; private set; }
    public String Name { get; private set; }

    public override bool Equals(object? obj)
    {
        if (obj is Student other)
            return Id == other.Id;
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString() => $"{Id} {Name}";

}
