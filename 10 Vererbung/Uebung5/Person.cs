namespace Uebung5
{
    public abstract class Person(string lastName, string firstName) : IPrintable, INameable
    {
        private readonly string lastName = lastName;
        public string FirstName { get; } = firstName;

        public string GetFullName()
        {
            return $"{FirstName} {lastName}";
        }

        public abstract void Print();
    }
}
