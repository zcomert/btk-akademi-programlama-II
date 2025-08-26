// See https://aka.ms/new-console-template for more information
class Library : ILibraryService
{
    private readonly SortedList<int, Book> books;
    public Library()
    {
        books = new SortedList<int, Book>();
    }

    public void AddBook(Book book)
    {
        if (books.ContainsKey(book.Id))
        {
            System.Console.WriteLine($"Id {book.Id} zaten tanımlı!");
            return;
        }
        books.Add(book.Id, book);
        System.Console.WriteLine($"{book.Title} başarılı bir şekilde eklendi.");
    }

    public void PrintAll()
    {
        System.Console.WriteLine("=== Kitap Listesi ===");
        foreach (var b in books)
        {
            System.Console.WriteLine(b.Value);
        }
    }

    public void RemoveAtPosition(int index)
    {
        if (index < 0 || index > books.Count)
        {
            System.Console.WriteLine("Geçersiz indeks!");
            return;
        }
        int key = books.Keys[index];
        books.RemoveAt(index);
        System.Console.WriteLine($"Indeks silindi: key={key}");
    }

    public bool RemoveBookById(int id)
    {
        bool removed = books.Remove(id);
        System.Console.WriteLine(removed ? $"Silindi: {id}" : $"Bulunamadı: {id}");
        return removed;
    }

    public bool TryFindById(int id, out Book book)
    {
        bool ok = books.TryGetValue(id, out book);
        System.Console.WriteLine(ok ? $"Bulundu: {book}" : $"Id : {id}");
        return ok;
    }

    public int IndexOfId(int id) => books.IndexOfKey(id);
}