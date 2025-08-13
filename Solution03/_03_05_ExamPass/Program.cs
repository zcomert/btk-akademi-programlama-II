// vize
Console.WriteLine("Vize notunuzu giriniz: ");
double midterm = Convert.ToDouble(Console.ReadLine());

// final
Console.WriteLine("Final notunuzu giriniz: ");
double finalExam = Convert.ToDouble(Console.ReadLine());

// nihai not
var finalGrade = (midterm * 0.4) + (finalExam * 0.6);
Console.WriteLine($"Nihai notunuz: {finalGrade}");

// karar
if (finalGrade >= 50)
    Console.WriteLine("Geçtiniz!");
else
    Console.WriteLine("Kaldınız!");

Console.ReadKey();
