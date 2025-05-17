using System;

abstract class Document
{
    public abstract void PrintContent();
    public void ShowDocumentType(string Type)
    {
        Console.WriteLine($"Document Type: {Type}");
    }
}
class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word Document");
    }
}
class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF Document");
    }
}
class Program
{
    static void Main()
    {
        Document doc;

        doc = new WordDocument();
        doc.ShowDocumentType("Word");
        doc.PrintContent();

        doc = new PDFDocument();
        doc.ShowDocumentType("PDF");
        doc.PrintContent();
    }
}