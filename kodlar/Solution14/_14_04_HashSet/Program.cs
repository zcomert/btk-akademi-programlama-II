
// Türkçe Açıklama: Öğrencilerin isimlerini saklayan HashSet
HashSet<string> classA = new HashSet<string>() { "Ali", "Ayşe", "Mehmet" };
HashSet<string> classB = new HashSet<string>() { "Ayşe", "Zeynep", "Hasan" };

// --- 1) Benzersizlik ---
Console.WriteLine("=== Benzersizlik ===");
bool added = classA.Add("Ali"); // "Ali" zaten mevcut
Console.WriteLine($"Ali tekrar eklendi mi? {added}"); // false döner

// --- 2) Küme İşlemleri ---
Console.WriteLine("\n=== Küme İşlemleri ===");

// Birleşim
HashSet<string> union = new HashSet<string>(classA);
union.UnionWith(classB);
Console.WriteLine("Birleşim: " + string.Join(", ", union));

// Kesişim
HashSet<string> intersect = new HashSet<string>(classA);
intersect.IntersectWith(classB);
Console.WriteLine("Kesişim: " + string.Join(", ", intersect));

// Fark
HashSet<string> difference = new HashSet<string>(classA);
difference.ExceptWith(classB);
Console.WriteLine("Fark (A - B): " + string.Join(", ", difference));

// --- 3) Hızlı Arama ---
Console.WriteLine("\n=== Hızlı Arama ===");
Console.WriteLine($"Ayşe var mı? {classA.Contains("Ayşe")}");
Console.WriteLine($"Hasan var mı? {classA.Contains("Hasan")}");

Console.ReadKey();
