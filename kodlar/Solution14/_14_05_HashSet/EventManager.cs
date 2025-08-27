class EventManager
{
    private HashSet<Student> attendees = new HashSet<Student>();
    private HashSet<Student> certified = new HashSet<Student>();
    public void AddAttendee(Student student) =>
        attendees.Add(student);
    public void AddCertified(Student student) =>
        certified.Add(student);

    public void PrintNotCertified()
    {
        var notCertified = new HashSet<Student>(attendees);
        notCertified.ExceptWith(certified);

        System.Console.WriteLine("\n=== Sertifika Almayanlar ===");
        foreach (var item in notCertified)
            System.Console.WriteLine(item);
    }

    public void PrintCertifiedAttendees()
    {
        var both = new HashSet<Student>(attendees);
        both.IntersectWith(certified);

        System.Console.WriteLine("\n=== Sertifika Alanlar ===");
        foreach (var item in both)
            System.Console.WriteLine(item);
    }

    public void PrintAllStudents()
    {
        var all = new HashSet<Student>(attendees);
        all.UnionWith(certified);

        System.Console.WriteLine("\n === Tüm Öğrencilerin Listesi ===");
        foreach (var item in all)
            System.Console.WriteLine(item);
        
    }
}