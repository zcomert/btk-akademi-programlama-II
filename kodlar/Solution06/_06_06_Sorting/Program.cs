var cities = new List<String> {"izmir",
    "İzmir",
    "Isparta",
    "isparta",
    "Istanbul",
    "istanbul",
    "samsun",
    "van",
    "adana"
};

// Ordinal sıralama
var ordinalSorted = new List<string>(cities);
ordinalSorted.Sort(StringComparer.Ordinal);

foreach (var item in ordinalSorted)
{
    System.Console.WriteLine(item);
}

// CurrentCultureIgnoreCase
System.Console.WriteLine($"\n{new string('-',10)}");
var culturedSorted = new List<string>(cities);
culturedSorted.Sort(StringComparer.CurrentCultureIgnoreCase);

foreach (var item in culturedSorted)
{
    System.Console.WriteLine(item);
}

Console.ReadKey();

