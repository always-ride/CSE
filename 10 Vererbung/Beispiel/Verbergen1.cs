/* Beispielklassen Verbergen */
/* Autor:   Digicomp      */
/* Sprache: C#               */

using System;

public class cAdresse
{
  protected string name;
  protected string strasse;
  protected string plz;
  protected string ort;

  public cAdresse()
  {
    this.name    = "";
    this.strasse = "";
    this.plz     = "";
    this.ort     = "";
  }

  public void SetAdr(string n,string s,string p,string o)
  {
    this.name = n;
    this.strasse = s;
    this.plz = p;
    this.ort = o;
  }

  public string GetAdr()
  {
    return string.Format("{0}\n{1}\n\n{2} {3}",
                         name,strasse,plz,ort);
  }
}


public class neuAdresse : cAdresse
{
  public neuAdresse()
  {
    //Konstruktoren werden nicht vererbt
  }

  new public string GetAdr()
  {
    return string.Format("{0}, {1} {2}",name,plz,ort);
  }
}

public class TestClass
{
  public static void Main()
  {
    cAdresse a1 = new cAdresse();
    neuAdresse a2 = new neuAdresse();

    Console.WriteLine("Geben Sie die Daten ein:");

    Console.Write("Name:    ");
    string n = Console.ReadLine();
    Console.Write("Straﬂe:  ");
    string s = Console.ReadLine();
    Console.Write("PLZ:     ");
    string p = Console.ReadLine();
    Console.Write("Ort:     ");
    string o = Console.ReadLine();

    a1.SetAdr(n,s,p,o);
    a2.SetAdr(n,s,p,o);


    Console.WriteLine("\nAusgabe cAdresse:\n-----------------");
    Console.WriteLine(a1.GetAdr());
    Console.WriteLine("\nAusgabe neuAdresse:\n-------------------");
    Console.WriteLine(a2.GetAdr());
  }
}