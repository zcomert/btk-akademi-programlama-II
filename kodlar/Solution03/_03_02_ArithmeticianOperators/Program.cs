namespace _03_02_ArithmeticianOperators
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Toplama
            int sum = 5 + 3;
            Console.WriteLine($"Toplam : {sum}");

            // Fark
            int a = 5;
            int b = 3;
            Console.WriteLine($"{a}-{b} = {a-b}");

            // Çarpım
            int c = a * b;
            Console.WriteLine($"{a}*{b} = {c}");

            // Bölme
            int d = a / b;
            var e = (double) a / b;
            Console.WriteLine($"d değişkenini tipi: {d.GetType()} ");
            Console.WriteLine($"e değişkenini tipi: {e.GetType()} ");
            Console.WriteLine($"{a}/{b} = {d}");
            Console.WriteLine($"{a}/{b} = {e}");

            int increase = 5;
            increase++;

            int decrease = 5;
            decrease--;

            Console.WriteLine($"Arttırma {increase}");
            Console.WriteLine($"Azaltma {decrease}");

            // Mod
            int f = a % b; // 2
            Console.WriteLine($"{a}%{b} = {f}");

            Console.ReadKey();

        }
    }
}
