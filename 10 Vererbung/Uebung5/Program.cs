namespace Uebung5
{
    class Program
    {
        public static void Main()
        {
            List<Person> people = CreatePeople();

            foreach (var person in people)
            {
                person.Print();
            }

            Console.WriteLine();
            Console.WriteLine($"Number of ladies: {Lady.NumberOfLadies}");
            Console.WriteLine($"Number of gents: {Gent.NumberOfGents}");
        }

        static List<Person> CreatePeople()
        {
            return
            [
                new Gent("Doe", "John"),
                new Lady("Smith", "Jane"),
                new Gent("Brown", "James"),
                new Lady("Johnson", "Emily")
            ];
        }
    }
}