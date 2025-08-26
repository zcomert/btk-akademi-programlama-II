class Student
{
    public Student(int id, string name, double gPA)
    {
        Id = id;
        Name = name;
        GPA = gPA;
    }

    public int Id { get; set; }
    public String Name { get; set; }
    public double GPA { get; set; }

    public override string ToString() =>
        $"{Id,-5} {Name,-20} {GPA}";
}
