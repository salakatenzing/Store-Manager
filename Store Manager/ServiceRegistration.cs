using Store_Manager.Repositories;


namespace Store_Manager
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //makes it available it to the Web API through Dependency Injection
            services.AddScoped<ProductRepository>();
            services.AddScoped<CustomerRepository>();
            services.AddScoped<OrderItemRepository>();
            services.AddScoped<OrderTableRepository>();
            services.AddScoped<ProductFrequencyRepository>();
        }
    }
}
