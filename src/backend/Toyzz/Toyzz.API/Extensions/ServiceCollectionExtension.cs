using Microsoft.EntityFrameworkCore;
using Toyzz.Domain.AggregatesModel.Blogs;
using Toyzz.Domain.SeedWork;
using Toyzz.Infrastructure;
using Toyzz.Infrastructure.Repositories;

namespace Toyzz.API.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddDbContext(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<BlogContext>(o => { o.UseSqlServer(configuration.GetConnectionString("Default")); });
        return services;
    }

    public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
    {
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IBlogRepository, BlogRepository>();
        return services;
    }
}