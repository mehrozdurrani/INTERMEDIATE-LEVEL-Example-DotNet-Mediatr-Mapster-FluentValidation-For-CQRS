using MediatR;

namespace UsingMediatrCQRS.Contracts
{
    public record RegisterRequest(string FirstName, string LastName) : IRequest<RegisterResponse>;
}
