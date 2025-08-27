using System.Collections;

internal class StudentManager
{
    private ArrayList students;
    public StudentManager()
    {
        students = new ArrayList();
    }
    public StudentManager(Student s) : this()
    {
        if (s is not null)
            students.Add(s);
    }

    public StudentManager(IEnumerable<Student> students) : this()
    {
        foreach (var student in students)
        {
            this.students.Add(student);
        }
    }

    public void Add(Student s)
    {
        if (s is null)
        {
            // hata fırlatma!
            System.Console.WriteLine("Geçersiz öğrenci!");
            return;
        }
        students.Add(s);
    }

    public void PrintAll()
    {
        System.Console.WriteLine("===Öğrenciler===");
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i] is Student st)
            {
                System.Console.WriteLine($"{st}");
            }
        }
    }
}