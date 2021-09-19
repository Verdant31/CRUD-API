using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Api.CrossCuting.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace application
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
      ConfigureService.ConfigureDependeciesService(services);
      ConfigureRepository.ConfigureDependeciesRepository(services);
      services.AddControllers();
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
          Version = "v1",
          Title = "API CRUD com AspNetCore",
          Description = "Arquitetura DDD",
          TermsOfService = new Uri("http://www.mfrinfo.com.br"),
          Contact = new OpenApiContact
          {
            Name = "João Pedro Soares Piovesan",
            Email = "verdantxd@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/jo%C3%A3o-pedro-soares-piovesan-724235191/")
          },
          License = new OpenApiLicense
          {
            Name = "Termo de Licença de Uso",
            Url = new Uri("https://github.com/Verdant31"),
          }
        }
        );
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Curso de API com AspNetCore 3.1");
        c.RoutePrefix = string.Empty;
      });

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
