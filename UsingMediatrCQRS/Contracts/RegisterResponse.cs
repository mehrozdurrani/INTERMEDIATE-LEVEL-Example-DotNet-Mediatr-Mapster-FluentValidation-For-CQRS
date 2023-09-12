using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Contracts
{
    public record RegisterResponse(Model.Person person, List<NotificationEvent> Events);
}
