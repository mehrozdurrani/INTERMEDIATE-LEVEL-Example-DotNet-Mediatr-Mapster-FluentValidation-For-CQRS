namespace UsingMediatrCQRS.Contracts
{
    public record GetAllPersonsResponse(List<Person> persons);

    public record Person(int Id, string FirstName, string LastName);
}
