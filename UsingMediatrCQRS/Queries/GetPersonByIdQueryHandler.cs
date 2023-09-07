using MediatR;
using UsingMediatrCQRS.DataStore;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Queries
{
    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Person?>
    {
        private readonly DummyDataStore _dummyDataStore;

        public GetPersonByIdQueryHandler(DummyDataStore dummyDataStore)
        {
            _dummyDataStore = dummyDataStore;
        }

        public async Task<Person?> Handle(
            GetPersonByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            await Task.CompletedTask;
            var person = await _dummyDataStore.GetPerson(request.Id);
            return person;
        }
    }
}
