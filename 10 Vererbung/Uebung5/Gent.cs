namespace Uebung5
{
    internal class Gent : Person, IGenderable
    {
        private static int numberOfGents = 0;

        public Gent(string lastName, string firstName) : base(lastName, firstName)
        {
            numberOfGents++;
        }

        public override void Print()
        {
            Console.WriteLine($"Gent: {GetFullName()} (Gender: {GetGender()})");
        }

        public string GetGender()
        {
            return "Male";
        }

        public static int NumberOfGents => numberOfGents;
    }
}
