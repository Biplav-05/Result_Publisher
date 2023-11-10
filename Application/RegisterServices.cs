
using Application.User_Service.Interface;
using Application.User_Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class RegisterServices
    {
        public static void ConfigureApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

        }
    }
}
