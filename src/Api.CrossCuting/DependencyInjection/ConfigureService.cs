using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCuting.DependencyInjection
{
  public class ConfigureService
  {
    public static void ConfigureDependeciesService(IServiceCollection serviceCollection)
    {
      serviceCollection.AddTransient<IUserService, UserService>();
    }
  }
}
