using System;

public class Primzahl
{
  public static bool CheckPrimZahl(int theValue)
  {
    if (theValue<3)
    {
      return(false);
    }

    for (int i=2;i<theValue;i++)
    {
      if ((theValue%i)==0)
        return (false);
    }
    return (true);
  }
}



public class Testclass
{
  public static void Main()
  {
    int Zahl = 0;

    Console.Write("Geben Sie eine Zahl ein: ");
    Zahl = Convert.ToInt32(Console.ReadLine());    
    if (Primzahl.CheckPrimZahl(Zahl))
    {
      Console.WriteLine("Die Zahl {0} ist eine Primzahl",Zahl);    
    }
    else
    {
      Console.WriteLine("Die Zahl {0} ist keine Primzahl",Zahl);
    }
    Console.ReadLine();
  }
}