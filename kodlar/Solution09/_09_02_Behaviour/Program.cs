using Behaviour.Models;

var employees = new Employee[]
{
    new Employee(1, "Ahmet", 30_000m),
    new Employee(2, "Fatma", 45_000m),
    new Employee(3, "Zeynep",50_000m),
    new Employee(4, "Ali", 30_000m),
    new Employee(5, "Nida",60_000m)
};

Array.Sort(employees);

foreach (var employee in employees)
{
    Console.WriteLine(employee);
}

Console.ReadKey();
