using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Contracts
{
    public record RegisterResponse(Person Person, List<NotificationEvent> Events);
}
