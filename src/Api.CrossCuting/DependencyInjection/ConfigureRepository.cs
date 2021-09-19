
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.CrossCuting.DependencyInjection
{
  public class ConfigureRepository
  {
    public static void ConfigureDependeciesRepository(IServiceCollection serviceCollection)
    {
      serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

      serviceCollection.AddDbContext<MyContext>(
        options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=123456123")
      );
    }
  }
}
