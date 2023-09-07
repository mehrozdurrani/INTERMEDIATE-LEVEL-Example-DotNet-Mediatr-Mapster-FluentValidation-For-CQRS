using MediatR;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<Person>;
}
