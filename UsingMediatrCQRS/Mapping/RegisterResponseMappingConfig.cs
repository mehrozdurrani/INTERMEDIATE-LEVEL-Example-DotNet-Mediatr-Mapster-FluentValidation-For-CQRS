using Mapster;
using UsingMediatrCQRS.Contracts;
using UsingMediatrCQRS.Model;
using Person = UsingMediatrCQRS.Model.Person;

namespace UsingMediatrCQRS.Mapping
{
    public class RegisterResponseMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config
                .NewConfig<(Person person, List<NotificationEvent> evs), RegisterResponse>()
                .ConstructUsing(
                    sourceMember => new RegisterResponse(sourceMember.person, sourceMember.evs)
                );
        }
    }
}
