namespace Inheritance
{
    public class Man : Person, IPrintable
    {
        public static int Counter { get; private set; }

        public Man(string lastName, string firstName) : base(lastName, firstName)
        {
            Counter++;
            ((IPrintable)this).Print();
        }

        ~Man()
        {
            Counter--;
        }

        void IPrintable.Print()
        {
            Console.WriteLine($"{FirstName} {LastName}, {Counter}");
        }

        //public void Print()
        //{
        //    Console.WriteLine($"{FirstName} {LastName}, {Counter}");
        //}
    }
}
