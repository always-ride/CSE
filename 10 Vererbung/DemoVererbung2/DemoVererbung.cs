namespace DemoVererbung;

/// <summary>
/// Summary description for Class1.
/// </summary>
public class Program
{
	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	public static void Main(string[] args)
	{
		//
		// TODO: Add code to start application here
		//
		Tier[] TierArray = new Tier[6];
/*			Tier theTier = new Tier();
		Console.WriteLine("Mein Name ist: {0}", theTier.getName());
*/			
		Saeugetier theSaeugetier = new Saeugetier();
		TierArray[0] = theSaeugetier;
		Kuh theKuh = new Kuh();
		TierArray[1] = theKuh;
		Schwein theSchwein = new Schwein();
		TierArray[2] = theSchwein;

		Vogel theVogel = new Vogel();
		TierArray[3] = theVogel;
		Adler theAdler = new Adler();
		TierArray[4] = theAdler;
		Spatz theSpatz = new Spatz();
		TierArray[5] = theSpatz;

		foreach(Tier iTier in TierArray)
		{
			Console.WriteLine("Ich bin vom Typ: {0} und heisse {1}", iTier.GetType().FullName.ToString(), iTier.getName());
		}
		
		Console.ReadLine();
	}
}



public abstract class Tier
{
	protected string Name = "";

	public Tier()
	{
		Name = "Tier";
	}

	virtual public string getName()
	{
		return (Name);
	}

}

public class Saeugetier : Tier
{

	public Saeugetier()
	{
		Console.WriteLine("Konstruktor der Saeugetier");
	}
	
	override public string getName()
	{
		return ("Saeugetier");
	}
}

public class Kuh : Saeugetier
{
	public Kuh()
	{
		Console.WriteLine("Konstruktor der Kuh");
	}
}

public class Schwein : Saeugetier
{
	public Schwein()
	{
		Console.WriteLine("Konstruktor der Schwein");
	}
}

public class Vogel : Tier
{
	public Vogel()
	{
		Console.WriteLine("Konstruktor der Vogel");
	}
}

public class Adler : Vogel
{
	public Adler()
	{
		Console.WriteLine("Konstruktor der Adler");
	}

	override public string getName()
	{
		return ("Adler / " + base.getName());
	}

}

public class Spatz : Vogel
{
	public Spatz()
	{
		Console.WriteLine("Konstruktor der Spatz");
	}

	override public string getName()
	{
		return ("Spatz");
	}

}
