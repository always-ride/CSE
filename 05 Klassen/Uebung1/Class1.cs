namespace Programmstrukturierung
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
            string HelperStr = "";

            Uebungen theUebungen = new Uebungen();
            System.Console.WriteLine(Uebungen.Multiply(23, 34));

            theUebungen.SetValue("Erster Teilstring ");
            HelperStr = "zweiter Teilstring";
            theUebungen.AddString(ref HelperStr);
            System.Console.WriteLine(HelperStr);

            System.Console.ReadLine();
            return 0;
        }
    }

    public class Uebungen
    {
        public string theString;
        public int theInteger;
        public double theDouble;

        public Uebungen()
        {
            // Standard Constructor
        }

        public Uebungen(string Str)
        {
            theString = Str;
        }

        public Uebungen(int Intgr)
        {
            theInteger = Intgr;
        }

        public Uebungen(double Dbl)
        {
            theDouble = Dbl;
        }

        public static int Multiply(int a, int b)
        {
            return (a * b);
        }

        public void SetValue(string theValue)
        {
            this.theString = theValue;
        }

        public void SetValue(int theValue)
        {
            this.theInteger = theValue;
        }

        public void SetValue(double theValue)
        {
            this.theDouble = theValue;
        }

        public void AddString(ref string theValue)
        {
            theValue = this.theString + theValue;
        }
    }
}

