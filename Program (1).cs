using System;
using System.Collections.Generic;

public abstract class Document
{
    public string Title { get; set; }

    protected Document(string title)
    {
        Title = title;
    }

    public abstract void Print();

    public void PrepareForPrinting()
    {
        Console.WriteLine($"Preparing document: {Title}");
        Print();
    }
}

public class PDFDocument : Document
{
    public PDFDocument(string title) : base(title) { }

    public override void Print()
    {
        Console.WriteLine($"[PDF] Printing: {Title}");
    }
}

public class WordDocument : Document
{
    public WordDocument(string title) : base(title) { }

    public override void Print()
    {
        Console.WriteLine($"[Word] Printing: {Title}");
    }
}

public class ExcelDocument : Document
{
    public ExcelDocument(string title) : base(title) { }

    public override void Print()
    {
        Console.WriteLine($"[Excel] Printing: {Title}");
    }
}

public static class DocumentFactory
{
    public static Document Create(string type, string title)
    {
        return type.ToLower() switch
        {
            "pdf"   => new PDFDocument(title),
            "word"  => new WordDocument(title),
            "excel" => new ExcelDocument(title),
            _       => throw new ArgumentException($"Unknown document type: {type}")
        };
    }
}

class Program
{
    static void Main()
    {
        List<Document> documents = new List<Document>
        {
            DocumentFactory.Create("pdf",   "Annual Report"),
            DocumentFactory.Create("word",  "Project Plan"),
            DocumentFactory.Create("excel", "Budget 2025")
        };

        foreach (Document doc in documents)
        {
            doc.PrepareForPrinting();
            Console.WriteLine();
        }
    }
}
