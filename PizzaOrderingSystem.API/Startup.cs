using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaOrderingSystem.API.DataManagers;
using PizzaOrderingSystem.FileRepositories.Classes;
using PizzaOrderingSystem.Managers.Classes;
using PizzaOrderingSystem.Managers.Contracts;
using ProjectAssignment.Repositories.Contracts;
namespace PizzaOrderingSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICartRepository, CartFileRepository>();
            services.AddScoped<IOrderRepository, OrderFileRepository>();
            services.AddScoped<IPaymentRepository, PaymentFileRepository>();
            services.AddScoped<IPizzaRepository, PizzaFileRepository>();
            services.AddScoped<IUserRepository, UserFileRepository>();


            services.AddScoped<IOrderDataManger, OrderDataManger>();
            services.AddScoped<IPizzaDataManager, PizzaDataManager>();
            services.AddScoped<IUsersDataManager, UsersDataManager>();
            services.AddScoped<ICartManager, CartManager>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
