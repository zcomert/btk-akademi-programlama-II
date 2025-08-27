// See https://aka.ms/new-console-template for more information
class Book
{
    public Book(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }

    public int Id { get; private set; }
    public String Title { get; private set; }
    public String Author { get; private set; }

    public void Rename(string newTitle) => Title = newTitle;
    public void ChangeAuthor(string authorName) => Author = authorName;

    public override string ToString() => $"{Id} {Title} - {Author}";

}