namespace Inheritance
{
    public class Woman : Person, IPrintable
    {
        public static int Counter { get; private set; }
        public Woman(string lastName, string firstName) : base(lastName, firstName)
        {
            Counter++;
        }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}, {Counter}");
        }

        ~Woman()
        {
            Counter--;
        }
    }
}
