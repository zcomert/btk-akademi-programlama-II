var manager = new StudentManager();

manager.Add("Ali");
manager.Add("Ayşe");
manager.Add("Mehmet");
manager.Add("Zeynep");

manager.PrintAll();

// Silme
manager.Remove("Ayşe");
manager.RemoveAt(0);
manager.PrintAll();

// Güncelleme
manager.Update(0, "Kemal");
manager.PrintAll();

// Araya ekleme
manager.Insert(1, "Gamze");
manager.PrintAll();

Console.ReadKey();