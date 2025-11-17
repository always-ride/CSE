namespace Inheritance
{
    public class Person 
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
