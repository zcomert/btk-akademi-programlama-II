// Tanımlama
using System.Collections;

var students = new ArrayList();

// Ekleme
students.Add("Ali");
students.Add("Ayşe");
students.Add("Mehmet");
students.Add("Zeynep");

Console.WriteLine("=== Başlangıç Listesi === ");
PrintList(students);

// Silme
students.Remove("Mehmet"); // 0 - 1 - 2
students.RemoveAt(0);

Console.WriteLine("=== Silme Sonra Liste === ");
PrintList(students);

// Güncelleme 
students[0] = "Fatma";

Console.WriteLine("=== Güncelleme Sonrası Liste === ");
PrintList(students);

// Araya ekleme
students.Insert(1, "Kemal");

Console.WriteLine("=== Araya Ekleme Sonrası Liste === ");
PrintList(students);

Console.ReadKey();

static void PrintList(ArrayList list)
{
    Console.WriteLine("");
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"Index: {i} -> {list[i]}");
    }
    Console.WriteLine("");
}