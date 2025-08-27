// manager
var manager = new EventManager();

// Öğrenciler
var s1 = new Student(1, "Ali");
var s2 = new Student(2, "Ayşe");  // Sertifika aldı
var s3 = new Student(3, "Mehmet");
var s4 = new Student(4, "Zeynep"); // Sertifika aldı

// katılımcılar 
manager.AddAttendee(s1);
manager.AddAttendee(s2);
manager.AddAttendee(s3);
manager.AddAttendee(s4);

// sertifika alanlar
manager.AddCertified(s2);
manager.AddCertified(s4);

// Raporlama
manager.PrintAllStudents();
System.Console.WriteLine("");
manager.PrintCertifiedAttendees();
System.Console.WriteLine("");
manager.PrintNotCertified();

Console.ReadKey();

