using MediatR;
using UsingMediatrCQRS.DataStore;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Commands
{
    public class RegisterPersonCommandHandler : IRequestHandler<RegisterPersonCommand, Person>
    {
        private readonly DummyDataStore _dummyDataStore;

        public RegisterPersonCommandHandler(DummyDataStore dummyDataStore)
        {
            _dummyDataStore = dummyDataStore;
        }

        public async Task<Person> Handle(
            RegisterPersonCommand request,
            CancellationToken cancellationToken
        )
        {
            var person = await _dummyDataStore.AddPerson(
                Person.Create(request.FirstName, request.LastName)
            );
            return person;
        }
    }
}
