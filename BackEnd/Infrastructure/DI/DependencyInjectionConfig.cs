using BackEnd.ContractRepository;
using BackEnd.ContractService;
using BackEnd.Repository;
using BackEnd.Service;
using Microsoft.Extensions.DependencyInjection;

namespace BackEnd.Infrastructure.DI
{
  public static class DependencyInjectionConfig
  {
    public static IServiceCollection ResolveDependencies(this IServiceCollection services)
    {
      services.AddScoped<ICadastroRepository, CadastroRepository>();
      services.AddScoped<ICadastroService, CadastroService>();

      return services;
    }
  }
}
