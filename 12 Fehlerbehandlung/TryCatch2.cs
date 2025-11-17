/* Beispiel try-catch-Block 2*/
/* Autor: Digicomp */
/* Sprache: C# */

using System;

class TestClass
{
  int doDivide( int a, int b)
  {
    try
    {
      return (a/b);
    }
    catch(DivideByZeroException e)
    {
      Console.WriteLine("Die Division durch 0 ist verboten");

    }
    catch(Exception e)
    {
      Console.WriteLine("Ausnahmefehler: {0}", e.Message);
    }
    finally
    {
      // wird immer ausgef�hrt
    }
  }
  public static void Main()
  {
    int a = Console.ReadLine();
    int b = Console.ReadLine();
    int x = doDivide(a,b);

  }
}