namespace DemoVererbung
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: Add code to start application here
			//
			BaseClass theBaseClass = new BaseClass();
			SubClass1 theSubClass1 = new SubClass1();
			SubClass2 theSubClass2 = new SubClass2();
			SubSubClass1 theSubSubClass1 = new SubSubClass1();
			SubSubClass2 theSubSubClass2 = new SubSubClass2();
			
			Console.ReadLine();
		}
	}
    public class BaseClass
	{
		private static int _nbr1 = 0;
		private int _nbr2 = 0;

		public BaseClass()
		{
			_nbr1++;
			_nbr2++;
			Console.WriteLine("Konstruktor der Basisklasse");
			Console.WriteLine("Nbr1 = {0}",_nbr1);
			Console.WriteLine("Nbr1 = {0}",_nbr2);
		}

	}

    public class SubClass1 : BaseClass
	{
		public SubClass1()
		{
			Console.WriteLine("Konstruktor der SubClass1");
		}
	}

    public class SubClass2 : BaseClass
	{
		public SubClass2()
		{
			Console.WriteLine("Konstruktor der SubClass2");
		}
	}

    public class SubSubClass1 : SubClass1
	{
		public SubSubClass1()
		{
			Console.WriteLine("Konstruktor der SubSubClass1");
		}
	}

    public class SubSubClass2 : SubClass1
	{
		public SubSubClass2()
		{
			Console.WriteLine("Konstruktor der SubSubClass2");
		}
	}

}
