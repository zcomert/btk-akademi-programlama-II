// dizi tanımlama 
int[] grades = new int[3];

// sayaç
int i = 0;

// do - while

do
{
    System.Console.WriteLine("Not giriniz: ");
    grades[i] = Convert.ToInt32(System.Console.ReadLine());
    i++;
} while (i<grades.Length);

System.Console.WriteLine("Girilen notlar:");

foreach (int grade in grades)
{
    System.Console.WriteLine(grade);
}

Console.ReadKey();