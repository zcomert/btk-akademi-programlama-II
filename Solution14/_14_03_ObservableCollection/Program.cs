var manager = new StudentManager();

manager.AddStudent(new Student(1, "Ali"));
manager.AddStudent(new Student(2, "Can"));
manager.AddStudent(new Student(3, "Zeynep"));
manager.AddStudent(new Student(4, "Fatma"));

manager.PrintAll();

manager.RemoveStudentById(3);
manager.PrintAll();

Console.ReadKey();