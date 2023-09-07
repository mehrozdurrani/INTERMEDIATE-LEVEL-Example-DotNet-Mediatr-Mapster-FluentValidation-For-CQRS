using MediatR;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Queries
{
    public record GetAllPersonsQuery() : IRequest<IEnumerable<Person>>;
}
