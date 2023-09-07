namespace UsingMediatrCQRS.Model
{
    public class Person
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public static Person Create(string firstName, string lastName)
        {
            int personId = new Random().Next(0, 100);
            return new(personId, firstName, lastName);
        }
    }
}
