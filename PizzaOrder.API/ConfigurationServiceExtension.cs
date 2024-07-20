using GraphQL;
using PizzaOrder.Application.Services.Implementation;
using PizzaOrder.Application.Services.Interface;

namespace PizzaOrder.API
{
    public static class ConfigurationServiceExtension
    {
        public static void AddCustomService(this IServiceCollection services)
        {
            services.AddTransient<IPizzaDetailService, PizzaDetailService>();
            services.AddTransient<IOrderDetailService, OrderDetailService>();

        }

        public static void AddCustomGraphQLServices(this IServiceCollection services)
        {
            //GraphQl services
            services.AddScoped<IServiceProvider>(c => new FuncServiceProvider(type => c.GetRequiredKeyedService(type)));
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = false; // false prints msg only, true will ToString
                options.UnhandledExceptionDelegate = context
            }
            )
        }
    }
}
