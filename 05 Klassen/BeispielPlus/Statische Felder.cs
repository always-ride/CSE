/* Beispielklasse statische Felder  */
/* Autor:   Digicomp                */
/* Sprache: C#                      */

public class Fahrzeug 
{
  int anzVerliehen;
  static int anzGesamt = 0;

  public void Ausleihen()
  {
    anzVerliehen++;
    anzGesamt++;
  }

  public void Zurueck()
  {
    anzVerliehen--;
    anzGesamt--;
  }

  public int GetAnzahl()
  {
    return (anzVerliehen)
  }

  public static int GetGesamt()
  {
    return (anzGesamt);
  }

}