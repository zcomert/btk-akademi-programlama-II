// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using System.Collections.Specialized;

class StudentManager
{
    public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();
    public StudentManager()
    {
        // Abonelik
        Students.CollectionChanged += OnStudentsChanged;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public bool RemoveStudentById(int id)
    {
        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].Id.Equals(id))
            {
                Students.RemoveAt(i);
                return true;
            }
        }
        System.Console.WriteLine("Id {id} bulunamadı.");
        return false;
    }

    public void PrintAll()
    {
        System.Console.WriteLine("=== Öğrenci Listesi ===");
        foreach (var s in Students)
            System.Console.WriteLine(s);
    }

    private void OnStudentsChanged(object? sender,
        NotifyCollectionChangedEventArgs e)
    {
        System.Console.WriteLine(e.Action);
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                if (e.NewItems is not null)
                    foreach (Student s in e.NewItems)
                        System.Console.WriteLine($"[+] Eklendi: {s}");
                break;
            case NotifyCollectionChangedAction.Remove:
                if (e.OldItems is not null)
                    foreach (Student s in e.OldItems)
                        System.Console.WriteLine($"[-] Silindi: {s}");
                break;
            default:
                System.Console.WriteLine("Reset!");
                break;
        }
    }
}

