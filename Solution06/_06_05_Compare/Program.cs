// örnekler
var a = "İstanbul";
var b = "istanbul";
var c = "Istanbul";

System.Console.WriteLine("== vs Equals");
System.Console.WriteLine($"{a}=={b} ? {a == b}"); // İ != i

System.Console.WriteLine($"Equals({a},{b}, StringComparison.OrdinalIgnoreCase) ? " +
$"{string.Equals(a,b, StringComparison.OrdinalIgnoreCase)}");

System.Console.WriteLine($"Equals({a},{b}, StringComparison.CurrentCultureIgnoreCase) ? " +
$"{string.Equals(a,b, StringComparison.CurrentCultureIgnoreCase)}");

Console.ReadKey();