class StudentManager
{
    private Dictionary<int, Student> students;
    public StudentManager()
    {
        students = new Dictionary<int, Student>();
    }

    public void AddStundet(Student student)
    {
        // Id kontolü : key tekrar edemez!
        if (!students.ContainsKey(student.Id))
        {
            students.Add(student.Id, student);
            System.Console.WriteLine($"{student.Name} başarıyla eklendi.");
        }
        else
        {
            System.Console.WriteLine($"{student.Id} numaralı öğrenci zaten mevcut");
        }
    }

    public void RemoveStudent(int id)
    {
        if (students.Remove(id))
            System.Console.WriteLine($"{id} numaralı öğrenci silindi.");
        else
            System.Console.WriteLine($"{id} numaralı öğrenci bulunamadı!");
    }

    public void FindStudent(int id)
    {
        // TryGetValue ile öğrenciyi arayacağız
        if (students.TryGetValue(id, out Student student))
            System.Console.WriteLine($"{student} bulundu.");
        else
            System.Console.WriteLine($"Öğrenci bulunamadı: {id}");
    }

    public void PrintAll()
    {
        System.Console.WriteLine("\n === Öğrenci Listesi ===");
        foreach (var s in students.Values)
        {
            System.Console.WriteLine(s);
        }
    }
}
