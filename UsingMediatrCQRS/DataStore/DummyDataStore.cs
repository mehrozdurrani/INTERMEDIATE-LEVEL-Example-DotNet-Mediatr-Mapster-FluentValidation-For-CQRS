using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.DataStore
{
    public class DummyDataStore
    {
        private List<Person> _persons = new();

        public DummyDataStore()
        {
            _persons.Add(Person.Create("Jon", "Doe"));
            _persons.Add(Person.Create("Robert", "Sim"));
            _persons.Add(Person.Create("Simon", "Dunt"));
        }

        public async Task<Person> AddPerson(Person person)
        {
            await Task.CompletedTask;
            _persons.Add(person);
            return person;
        }

        public async Task<IEnumerable<Person>> GetAllPersons() => await Task.FromResult(_persons);

        public async Task<Person?> GetPerson(int id)
        {
            await Task.CompletedTask;
            var person = _persons.SingleOrDefault(person => person.Id == id);
            return person;
        }

        public async Task PersonRegisterEventOccured(Person person, string ev)
        {
            _persons.Single(p => p.Id == person.Id).Events += $"Event Occured {ev}, ";
            await Task.CompletedTask;
        }
    }
}
