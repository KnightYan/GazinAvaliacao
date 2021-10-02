using Gazin.Domain.interfaces.Services.Desenvolvedor;
using Gazin.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Gazin.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDesenvolvedorService, DesenvolvedorService>();
        }
    }
}
