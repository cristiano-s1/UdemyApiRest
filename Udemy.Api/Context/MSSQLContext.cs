using Microsoft.EntityFrameworkCore;
using Udemy.Api.Models;

namespace Udemy.Api.Context;

public class MSSQLContext : DbContext
{
    public MSSQLContext()
    { }

    public MSSQLContext(DbContextOptions<MSSQLContext> options) : base(options) { }

    public DbSet<Person> Persons { get; set; } = default!;
    public DbSet<Book> Books { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;
}
