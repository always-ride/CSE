/* Beispiel Geometrie */
/* Autor: Digicomp */
/* Sprache: C# */

public class TestClass
{
  public static void Main()
  {
    GeoClass[] geo = new GeoClass[3];
    geo[0] = new Rechteck(10,20);
    geo[1] = new Kreis(30);
    geo[2] = new Quadrat(20);
    foreach (GeoClass g in geo)
    {
      if (g is IGeometric)
      {
        IGeometric x = (IGeometric) (g);
        Console.WriteLine(x.GetArea());
        Console.WriteLine(x.GetPerimeter());
      }
      else 
      {
        Console.WriteLine("Interface nicht implementiert");
      }
    }

  }
}