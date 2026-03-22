namespace Udemy.Api.Repository;

public interface IPersonRepository : IRepository<Person>
{
    Person? Disable(int id);
    List<Person> FindByName(string? firstName, string? lastName);
}
