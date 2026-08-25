class Schaltjahr
{
    public static bool IsSchaltjahr(int x)
    {
        return x % 400 == 0 ? true :
               x % 100 == 0 ? false :
               x %   4 == 0;
    }
}

public class Testclass
{
    public static void Main()
    {
        while (true) 
        {
            try { TestSchaltjahr(); }
            catch (FormatException) { continue; }    
            catch (OverflowException) { continue; }
            
            Console.Write("Verlassen mit 'e' für exit: ");
            if (Console.ReadKey().KeyChar == 'e') { break; }
        }
    }

    private static void TestSchaltjahr()
    {
        Console.Write("\nGeben Sie eine Jahreszahl ein: ");

        int jahr = Convert.ToInt32(Console.ReadLine());
        string wasDenkstDu = Schaltjahr.IsSchaltjahr(jahr) ? "ein" : "kein";

        Console.WriteLine($"Das Jahr {jahr} ist {wasDenkstDu} Schaltjahr");
    }
}