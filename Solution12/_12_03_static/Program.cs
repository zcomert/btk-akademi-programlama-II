using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace _12_03_static;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine($"PI : {MathHelper.PI}");
        System.Console.WriteLine($"5 karesi : {MathHelper.Square(5)}");

        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Counter c3 = new Counter();

        System.Console.WriteLine($"Toplam sayaç sayısı: {Counter.Count}");
        Console.ReadKey();
    }
}
