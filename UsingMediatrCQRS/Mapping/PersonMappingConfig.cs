using Mapster;
using UsingMediatrCQRS.Commands;
using UsingMediatrCQRS.Contracts;

namespace UsingMediatrCQRS.Mapping
{
    public class PersonMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            /*
            IMPORTANT: Below is just a simple example of how to configure map between two different classes.
            One cannot see the proper use of it below but it can come in handy for the scenarios such as
            if Request has 'FirstName' and 'LastName' but command has one attrubute 'FullName' then we will
            map it as '.Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}"). In this Scenario
            mapping can very usful
            */
            config
                .NewConfig<RegisterRequest, RegisterPersonCommand>()
                .Map(
                    destinationMember => destinationMember.FirstName,
                    sourceMember => sourceMember.FirstName
                )
                .Map(
                    destinationMember => destinationMember.LastName,
                    sourceMember => sourceMember.LastName
                );
        }
    }
}
