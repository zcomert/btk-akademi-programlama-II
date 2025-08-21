using System;

namespace Docs.Words;

public class WordDocument : Document
{
    public WordDocument(string title) : base(title)
    {

    }
    public override void Print()
    {
        base.Print();
        System.Console.WriteLine($"Word belgesi yazdırılıyor: {Title}");
    }
}


