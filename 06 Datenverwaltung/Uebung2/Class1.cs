namespace Step1
{
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

            theZahlenKlasse.SetA(10);
            theZahlenKlasse.SetB(8);
            Console.WriteLine(theZahlenKlasse.DoDivide().ToString());

            Console.WriteLine(theZahlenKlasse.StrDivide());

            Console.WriteLine(theZahlenKlasse.DoMultiply(12.4, 13.567));

            Console.WriteLine(theZahlenKlasse.DoDivide(213, 2));
            //Console.WriteLine(theZahlenKlasse.DoDivide(8748743, 2));

            Console.WriteLine(StringFormatter.DoFormat("die", " Digicomp"));

            Console.ReadLine();
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
        public int GetA()
        {
            return (a);
        }

        public int GetB()
        {
            return (b);
        }

        public void SetA(int a)
        {
            this.a = a;
        }

        public void SetB(int b)
        {
            this.b = b;
        }

        public double DoDivide()
        {
            double x = a;
            return (x / b);
        }
        public string StrDivide()
        {
            double x = DoDivide();
            return (string.Format("{0:F3}", x));
        }
        public int DoMultiply(double a, double b)
        {
            return ((int)(a * b)); // Nachkommastellen gehen verloren !!
        }

        public short DoDivide(int a, int b)
        {
            checked
            {
                return ((short)(a / b));
            }
        }
    }
    class StringFormatter
    {
        public static string DoFormat(string a, string b)
        {
            string c = string.Concat(a, b);
            return (c.PadLeft(20));
        }
    }
}
