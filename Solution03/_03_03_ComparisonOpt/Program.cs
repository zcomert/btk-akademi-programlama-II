namespace _03_03_ComparisonOpt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci tam sayıyı giriniz: ");
            int? a = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci tam sayıyı giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a}!={b} = {a!=b}");
            Console.WriteLine($"{a}>{b} = {a>b}");
            Console.WriteLine($"{a}<{b} = {a < b}");
            Console.WriteLine($"{a}={b} = {a == b}");

            Console.ReadKey();
        }
    }
}
