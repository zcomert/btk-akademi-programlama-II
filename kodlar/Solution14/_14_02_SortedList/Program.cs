ILibraryService library = new Library();
// ILibraryService library = new LibraryDic();

library.AddBook(new Book(30, "Domain Driven Design", "Eric Evans"));
library.AddBook(new Book(10, "Clean Code", "Robert Martin"));
library.AddBook(new Book(20, "The Pragmatic Programmer", "Andrew Hunt"));

library.PrintAll();

library.TryFindById(20, out Book book);
library.RemoveAtPosition(0);
library.PrintAll();

var libImp = library as Library;
System.Console.WriteLine($"Id 20 indeks: {libImp?.IndexOfId(20)}");

Console.ReadKey();
