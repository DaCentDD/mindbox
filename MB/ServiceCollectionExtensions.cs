using MB.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MB;

public static class ServiceCollectionExtensions
{
    public static void AddSquare(this IServiceCollection services)
    {
        services.AddScoped<ISquare, Square>();
        services.AddScoped<ICalculatorFactory, CalculatorFactory>();
    }
}