namespace Udemy.Api.Models;

public class Person : BaseEntity
{
    public string Address { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public bool Enabled { get; set; }
}
