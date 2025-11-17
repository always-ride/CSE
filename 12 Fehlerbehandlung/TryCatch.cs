/* Beispiel try-catch-Block */
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
    catch(Exception e)
    {
      Console.WriteLine("Ausnahmefehler: {0}", e.Message);
    }
  }
  public static void Main()
  {
    int a = Console.ReadLine();
    int b = Console.ReadLine();
    int x = doDivide(a,b);

  }
}