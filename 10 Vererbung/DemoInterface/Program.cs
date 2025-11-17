using System;

namespace InterfaceDemo
{
    /* Beispiel Interface 1 */
    /* Autor:   Digicomp */
    /* Sprache: C#          */



    //
    // Interface
    //

    interface IGeometric
    {
        double GetArea();      // kein public (Schnittstellen sind 
        double GetPerimeter(); // implizit public)
    }

    //
    // Geometrische Klasse
    //

    abstract public class GeoClass
    {
        abstract public void DrawScreen();  // Code zum Zeichnen auf dem Bildschirm
        abstract public void DrawPrinter(); // Code zum Zeichen auf dem Drucker
    }

    //
    // abgeleitete Klassen
    //

    public class Rechteck : GeoClass, IGeometric
    {
        private double seiteA = 0.0;
        private double seiteB = 0.0;

        public Rechteck() { } // Standard-Konstruktor

        public Rechteck(double seiteA, double seiteB)
        {
            this.seiteA = seiteA;
            this.seiteB = seiteB;
        }

        public override void DrawScreen()  { } // Code zum Zeichnen auf dem Bildschirm
        public override void DrawPrinter() { } // Code zum Zeichen auf dem Drucker

        //Implementation der Interface-Methoden
        public double GetArea()
        {
            return seiteA * seiteB;
        }

        public double GetPerimeter()
        {
            return 2 * seiteA + 2 * seiteB;
        }
    }

    public class Kreis : GeoClass, IGeometric
    {
        private double radius = 0.0;

        public Kreis()
        {
            // Standard-Konstruktor
        }

        public Kreis(double radius)
        {
            this.radius = radius;
        }

        public override void DrawScreen() { } // Code zum Zeichnen auf dem Bildschirm
        public override void DrawPrinter() { } // Code zum Zeichen auf dem Drucker

        // Implementation der Interface-Methoden
        public double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }
    }

    public class Quadrat : GeoClass, IGeometric
    {
        private double seiteA = 0.0;

        public Quadrat()
        {
            // Standard-Konstruktor
        }

        public Quadrat(double seiteA)
        {
            this.seiteA = seiteA;
        }

        public override void DrawScreen() { } // Code zum Zeichnen auf dem Bildschirm
        public override void DrawPrinter() { } // Code zum Zeichen auf dem Drucker

        //Implementation der Interface-Methoden
        public double GetArea()
        {
            return Math.Pow(seiteA, 2);
        }

        public double GetPerimeter()
        {
            return seiteA * 4;
        }
    }

    class Program
    {
        public static void Main()
        {
            IGeometric[] geo = new IGeometric[3];
            geo[0] = new Rechteck(10, 20);
            geo[1] = new Kreis(30);
            geo[2] = new Quadrat(20);

            foreach (IGeometric g in geo)
            {
                Console.WriteLine(g.GetArea());
                Console.WriteLine(g.GetPerimeter());
            }
        }
    }
}
