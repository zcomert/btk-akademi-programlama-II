namespace Docs.PDF;

public class PdfDocument : Document
{
    public PdfDocument(string title) : base(title)
    {

    }

    public override void Print()
    {
        // base.Print();
        System.Console.WriteLine($"PDF belgesi yazdırılıyor: {Title}");
    }
}


