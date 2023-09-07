using MediatR;
using UsingMediatrCQRS.DataStore;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Queries
{
    public class GetAllPersonsQueryHandler
        : IRequestHandler<GetAllPersonsQuery, IEnumerable<Person>>
    {
        private readonly DummyDataStore _dummyDataStore;

        public GetAllPersonsQueryHandler(DummyDataStore dummyDataStore)
        {
            _dummyDataStore = dummyDataStore;
        }

        public Task<IEnumerable<Person>> Handle(
            GetAllPersonsQuery request,
            CancellationToken cancellationToken
        )
        {
            var persons = _dummyDataStore.GetAllPersons();
            return persons;
        }
    }
}
