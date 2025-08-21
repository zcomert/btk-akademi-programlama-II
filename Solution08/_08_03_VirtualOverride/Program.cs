using Docs;
using Docs.PDF;
using Docs.Words;

var doc1 = new Document("Genel Rapor");
var doc2 = new PdfDocument("Finansal Rapor");
var doc3 = new WordDocument("Toplatı Notları");

doc1.Print();
doc2.Print();
doc3.Print();

Console.ReadKey();