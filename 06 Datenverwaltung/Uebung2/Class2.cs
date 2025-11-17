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
    }
}
