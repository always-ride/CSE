namespace Singleton
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
            // Der Sinn des Singleton Patterns ist es, eine statische Methode für die (indirekte
            // Erzeugung - hier getInstance() ) zur Verfügung zu stellen, die als statische Methode 
            // von überall aufgerufen werden kann wo die entsprechende Klasse sichtbar ist. 
            // Von einem Singleton kann nur eine Instanz erstellt werden.

            OneAndOnly.getInstance();
            Console.WriteLine("Es gibt {0} Objekt(e) vom Typ OneAndOnly!", OneAndOnly.Counter);
            OneAndOnly.getInstance();
            Console.WriteLine("Es gibt {0} Objekt(e) vom Typ OneAndOnly!", OneAndOnly.Counter);
            OneAndOnly.getInstance();
            Console.WriteLine("Es gibt {0} Objekt(e) vom Typ OneAndOnly!", OneAndOnly.Counter);
            OneAndOnly.getInstance();
            Console.WriteLine("Es gibt {0} Objekt(e) vom Typ OneAndOnly!", OneAndOnly.Counter);
   //         OneAndOnly theOneAndOnly = new OneAndOnly();  // nicht kompilierbar 
            Console.ReadLine();
            return 0;
        }
    }
    
    public class OneAndOnly
    {
      private static OneAndOnly instance = null;
      public static int Counter = 0; // just for testing
      
      private OneAndOnly()
      {
        // Default Konstruktor
        Counter++;              // just for testing
      }

      static public OneAndOnly getInstance()
      {
        if(instance == null)
        {
          instance = new OneAndOnly();
        }
        return(instance);
      }
    }
}
