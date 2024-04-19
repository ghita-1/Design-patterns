using System;


public class Adaptee
{
    public string SpecificRequest()
    {
        return "Adaptee: SpecificRequest() called";
    }
}


// Target interface
public interface ITarget
{
    string Request();
}

// Adapter class
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string Request()
    {
        // Adapt the Adaptee's interface to the Target's interface
        return $"Adapter: {_adaptee.SpecificRequest()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Adaptee
        Adaptee adaptee = new Adaptee();

        // Create an instance of Adapter, passing Adaptee instance to its constructor
        ITarget adapter = new Adapter(adaptee);

        // Call the Request method of the Adapter
        Console.WriteLine(adapter.Request());
        Console.ReadKey();
    }
}


