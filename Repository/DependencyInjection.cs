using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Repository;
public static class DependencyInjection
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddTransient<IOrderRepository, OrderRepository>();
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        services.AddDbContext<DataContext>(opt => opt
            .UseSqlServer("Server=.; Database=OrderDb;Trusted_Connection=True;"));
        return services;
    }
}