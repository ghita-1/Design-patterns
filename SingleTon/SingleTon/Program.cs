using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Singleton
{
    private static Singleton _instance;

    // Private constructor to prevent instantiation from outside
    private Singleton() { }

    public static Singleton GetInstance()
    {
        // Lazy initialization: create instance only when requested for the first time
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Accessing the singleton instance
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();

        Console.WriteLine(singleton1 == singleton2); // Output: True, both variables point to the same instance
        Console.ReadKey();
    }
}

