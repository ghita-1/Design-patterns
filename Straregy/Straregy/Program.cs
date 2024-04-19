using System;
using System.IO;

// Strategy interface
public interface ISaveStrategy
{
    void Save(string fileName, string content);
}

//  strategy for saving as text 
public class TextSaveStrategy : ISaveStrategy
{
    public void Save(string fileName, string content)
    {
        File.WriteAllText(fileName + ".txt", content);
        Console.WriteLine($"File saved as {fileName}.txt");
    }
}

//  strategy for saving as PDF 
public class PdfSaveStrategy : ISaveStrategy
{
    public void Save(string fileName, string content)
    {
        // Simulate saving as PDF
        Console.WriteLine($"File saved as {fileName}.pdf");
    }
}

//  strategy for saving as DOC 
public class DocSaveStrategy : ISaveStrategy
{
    public void Save(string fileName, string content)
    {
        // Simulate saving as DOC
        Console.WriteLine($"File saved as {fileName}.doc");
    }
}

// Context class
public class FileSaver
{
    private ISaveStrategy _saveStrategy;

    public FileSaver(ISaveStrategy saveStrategy)
    {
        _saveStrategy = saveStrategy;
    } 

    public void SetSaveStrategy(ISaveStrategy saveStrategy)
    {
        _saveStrategy = saveStrategy;
    }

    public void SaveFile(string fileName, string content)
    {
        _saveStrategy.Save(fileName, content);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a FileSaver instance with a TextSaveStrategy
        FileSaver fileSaver = new FileSaver(new TextSaveStrategy());

        // Save content as text file
        fileSaver.SaveFile("document1", "This is a text document.");

        // Change the save strategy to PdfSaveStrategy
        fileSaver.SetSaveStrategy(new PdfSaveStrategy());

        // Save content as PDF file
        fileSaver.SaveFile("document2", "This is a PDF document.");

        // Change the save strategy to DocSaveStrategy
        fileSaver.SetSaveStrategy(new DocSaveStrategy());

        // Save content as DOC file
        fileSaver.SaveFile("document3", "This is a DOC document.");
        Console.ReadKey();
    }
}

