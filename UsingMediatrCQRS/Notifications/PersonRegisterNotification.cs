using MediatR;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Notifications
{
    public record PersonRegisterNotification(Person person) : INotification;
}
