namespace Udemy.Api.DependencyInjection;

public class ConfigureRepository
{
    public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, string connection)
    {
        serviceCollection.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        serviceCollection.AddScoped<IPersonRepository, PersonRepository>();
        serviceCollection.AddScoped<IUserRepository, UserRepository>();

        serviceCollection.AddDbContext<MSSQLContext>(options => options.UseSqlServer(connection,
            sqlServerOptions => sqlServerOptions.CommandTimeout(300000)));
    }
}
