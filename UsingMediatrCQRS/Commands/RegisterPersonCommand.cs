using MediatR;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Commands
{
    public record RegisterPersonCommand(string FirstName, string LastName) : IRequest<Person>;
}
