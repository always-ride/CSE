using System;

class Schaltjahr
{
    public static bool IsSchaltjahr(int x)
    {
        // TODO
        return true;
    }
}


public class Testclass
{
    public static void Main()
    {
        Console.Write("Geben Sie eine Jahreszahl ein: ");
        int Jahr = Convert.ToInt32(Console.ReadLine());
        if (Schaltjahr.IsSchaltjahr(Jahr))
        {
            Console.WriteLine("Das Jahr {0} ist ein Schaltjahr", Jahr);
        }
        else
        {
            Console.WriteLine("Das Jahr {0} ist kein Schaltjahr", Jahr);
        }
        Console.ReadLine();
    }
}