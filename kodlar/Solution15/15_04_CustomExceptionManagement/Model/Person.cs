using Errors;

namespace Models;
public class Person
{
    private int age;

    public Person(int age, string? name)
    {
        Age = age;
        Name = name;
    }

    public String? Name { get; set; } = string.Empty;
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if(value <20 || value>90)
            {
                throw new InvalidAgeException("Yaş 20 ve 90 arasında olmalıdır!");
            }
            age = value;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Kişi: {Name,-10}, Yaş: {Age,-5}");
    }
}
