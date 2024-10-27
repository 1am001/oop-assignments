using System;

class Program
{
    static void Main ()
    {
        Print ("Fahad Hossain Lam");
        Print ('E');
    }

     static void Print (string name)
    {
        Console.WriteLine("Name: " + name);
    }

    static void Print (char group)
    {
        Console.WriteLine("Group: " + group);
    }
}
