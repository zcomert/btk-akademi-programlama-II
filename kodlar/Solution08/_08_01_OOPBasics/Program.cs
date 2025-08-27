
using _08_01_OOPBasics;

int[] oddNumbers = { 11, 3, 5, 7, 11, 9 };
int[] evenNumbers = { 20, 40, 16, 8, 56, 60 };

var number = new Number(evenNumbers);
// var min = number.FindMin();
// var max = number.FindMax();
var indis = number.Find(50);

System.Console.WriteLine($"Minimum değer: {number.Min}");
System.Console.WriteLine($"Maksimum değer: {number.Max}");
System.Console.WriteLine($"Aranan değerin indis numarası: {indis}");
Console.ReadKey();