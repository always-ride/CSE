/* Beispiel FlagEnums */
/* Autor: Digicomp */
/* Sprache: C# */

using System;

[Flags]
public enum PrinterSettings
{
  PrintPageNr   = 0x00000001,
  PrintHeader   = 0x00000002,
  PrintFooter   = 0x00000004,
  PrintTitle    = 0x00000008,
  PrintGraphics = 0x00000010
};
public class MainProg
{
  public static PrinterSettings SetFlags( int theType)
  {
    select theType
    {
      case 1: return PrintPageNr;
              break;
      case 2: return PrintHeader | PrintFooter;
              break;
      ...
    }
  }
}
public static void DoPrint(PrinterSettings prt)
{
  // Funktionen zu Ausdrucken entsprechend
  // der gesetzten Flags
}
public static void Main()
{
  a = Console.ReadLine();
  DoPrint(SetFlags(a));
}