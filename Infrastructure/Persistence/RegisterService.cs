
using Application.User_Service.Interface;
using Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence
{
    public static class RegisterService
    {
        public static void ConfigureInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<RMS_Dbcontext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("dbConnection")));
            service.AddScoped<IUserRepository, UserRepository>();
        }

    }
}
