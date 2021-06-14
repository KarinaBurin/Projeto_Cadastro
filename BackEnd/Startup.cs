using BackEnd.Helpers;
using BackEnd.Infrastructure.DI;
using BackEnd.Infrastructure.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BackEnd
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
      services.AddConfiguration<SettingsApplication>(Configuration, "SettingsApplication");

      //var settings = Configuration.GetSection("SettingsApplication").Get<SettingsApplication>();
      //services.AddJwtSecurity(signingConfigurations, settings);

      services.AddControllers();

     
      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
      services.ResolveDependencies();
      services.AddSwaggerDocs();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      

      app.UseHttpsRedirection();
      app.UseSwaggerDocs();
      app.UseRouting();
      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
