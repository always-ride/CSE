namespace Step1
{
    using System;

    /// <summary>
    ///    Summary description for Class1.
    /// </summary>
    public class Class1
    {
        public Class1()
        {
            //
            // TODO: Add Constructor Logic here
            //
        }

        public static int Main(string[] args)
        {
            ZahlenKlasse theZahlenKlasse = new ZahlenKlasse();  

            theZahlenKlasse.setA(10);
            theZahlenKlasse.setB(8);
            System.Console.WriteLine(theZahlenKlasse.doDivide().ToString());
          
            System.Console.WriteLine(theZahlenKlasse.strDivide());

            System.Console.WriteLine(theZahlenKlasse.doMultiply(12.4, 13.567));

            System.Console.ReadLine();
            return 0;
        }
    }
    
    public class ZahlenKlasse
    {
      private int a = 0;
      private int b = 0;

      public ZahlenKlasse()
      {
        // Default Konstruktor
      }
      public int getA()
      {
        return(a);
      }

      public int getB()
      {
        return(b);
      }

      public void setA(int a)
      {
        this.a = a;
      }

      public void setB(int b)
      {
        this.b = b;
      }

      public double doDivide()
      {
        double x = a;
        return(x/b);
      }
      public string strDivide()
      {
        double x = doDivide();
        return (string.Format("{0:F3}",x));
      }
      public int doMultiply(double a, double b)
      {
        return ((int) (a*b)); // Nachkommastellen gehen verloren !!
      }
    }
}
