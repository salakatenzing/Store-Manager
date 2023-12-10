using Store_Manager.Repositories;


namespace Store_Manager
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ProductRepository>();
            services.AddScoped<CustomerRepository>();
           
        }
    }
}
