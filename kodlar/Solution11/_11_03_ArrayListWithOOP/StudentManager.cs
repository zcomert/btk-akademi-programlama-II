// See https://aka.ms/new-console-template for more information
using System.Collections;

public class StudentManager
{
    private ArrayList students;
    public StudentManager()
    {
        students = new ArrayList();
    }

    public void Add(String name)
    {
        students.Add(name);
        Console.WriteLine("Eklendi: " + name);
    }

    public void Remove(String name)
    {
        students.Remove(name);
        Console.WriteLine("Silindi:" + name);
    }

    public void RemoveAt(int index)
    {
        if (index>=0 && index < students.Count)
        {
            Console.WriteLine("Silindi:" + students[index]);
            students.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Geçersiz index!");
        }
        
    }

    public void Update(int index, String name)
    {
        students[index] = name;
    }

    public void Insert(int index, String name)
    {
        students.Insert(index, name);   
    }

    public void PrintAll()
    {
        Console.WriteLine("===Öğrenci Listesi===");
        foreach (var item in students)
        {
            Console.WriteLine(item);
        }
    }
}