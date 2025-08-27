Number number = new Number();   // Referans | Physical

number.SingleNumber = -10;
number.Description = "Numaralar üzerinde işlem yapmak üzere tasarlanmış sınıfımızdır.";
number.Count = 0;

var number2 = new Number()
{
    SingleNumber = 20,
    Description = "20 sayısını ele alacağım.",
    Count = 100
};


var number3 = new Number(55,"55 sayısını dikkate al.");

System.Console.WriteLine($"Number:{number.SingleNumber}");
System.Console.WriteLine($"Count:{number.Count}");

System.Console.WriteLine($"Number:{number2.SingleNumber}");
System.Console.WriteLine($"Count:{number2.Count}");

System.Console.WriteLine($"Number:{number3.SingleNumber}");
System.Console.WriteLine($"Count:{number3.Count}");

Console.ReadKey();
