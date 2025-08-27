var intRepo = new GenericRepository<int>();
intRepo.Add(1);
intRepo.Add(2);
intRepo.Add(3);

intRepo.PrintWithMessage("Tam sayı listesi");

var strRepo = new GenericRepository<String>();
strRepo.Add("Ahmet");
strRepo.Add("Can");
strRepo.Add("Filiz");

strRepo.PrintWithMessage("String Listesi");

Console.ReadKey();
