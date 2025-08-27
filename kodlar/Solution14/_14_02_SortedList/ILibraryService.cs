// See https://aka.ms/new-console-template for more information
interface ILibraryService
{
    void AddBook(Book book);
    bool RemoveBookById(int id);
    void RemoveAtPosition(int index);
    bool TryFindById(int id, out Book book);
    void PrintAll();
}