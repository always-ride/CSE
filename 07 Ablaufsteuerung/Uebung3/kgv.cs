using System;

  public class KGVClass
  {
    public static int GetKGV(int a, int b)
    {
      int helpVal= a;
      bool isOk = false;
      do
      {
        isOk = (((helpVal%a)==0)&&((helpVal%b)==0));
        if (!isOk)
          helpVal++;
      } while (!isOk); 
      return (helpVal);
    }
  }

  public class TestClass
  {
    public static void Main()
    {

      Console.Write("Wert 1: ");
      int v1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Wert 2: ");
      int v2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("KGV: {0}",KGVClass.GetKGV(v1,v2));
      Console.ReadLine();
    }
  }
