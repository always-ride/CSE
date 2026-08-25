namespace Uebung5
{
    public class Lady : Person, IGenderable
    {
        private static int numberOfLadies = 0;

        public Lady(string lastName, string firstName) : base(lastName, firstName)
        {
            numberOfLadies++;
        }

        public override void Print()
        {
            Console.WriteLine($"Lady: {GetFullName()} (Gender: {GetGender()})");
        }

        public string GetGender()
        {
            return "Female";
        }

        public static int NumberOfLadies => numberOfLadies;
    }
}
