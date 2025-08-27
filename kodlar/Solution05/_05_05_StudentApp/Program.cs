



namespace _05_05_StudentApp;

class Program
{
    static void Main(string[] args)
    {
        // dizi tanımlama
        int[] grades = { 70, 85, 90, 60, 100, 75, 83, 92, 55, 78 };

        // ortalama hesaplama
        double average = CalculateAverage(grades);
        (int minGrade, int maxGrade) = FindMinMax(grades);

        // ortalamanın üzerindeki not sayısı 
        int count = CountAboveAverage(grades, average);

        System.Console.WriteLine($"Notlar: {string.Join(",", grades)}");
        System.Console.WriteLine($"Ortalama: {average:F2}");
        System.Console.WriteLine($"En düşük not: {minGrade:F2}");
        System.Console.WriteLine($"En yüksek not: {maxGrade:F2}");
        System.Console.WriteLine($"Ortalamanın üzerindeki not sayısı: {count}");

        Console.ReadKey();
    }

    private static int CountAboveAverage(int[] grades, double average)
    {
        int count = 0;
        int i = 0;
        while (i < grades.Length)
        {
            if (grades[i] > average)
                count++;
            i++;
        }
        return count;
    }

    private static (int minGrade, int maxGrade) FindMinMax(int[] grades)
    {
        int min = grades[0];
        int max = grades[0];

        foreach (var g in grades)
        {
            if (g < min) min = g;
            if (g > max) max = g;
        }
        return (min, max);
    }

    private static double CalculateAverage(int[] grades)
    {
        // kontrol 
        if (grades == null || grades.Length == 0)
        {
            return 0; // veya uygun bir hata işleme
        }

        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return (double)sum / grades.Length;
    }
}
