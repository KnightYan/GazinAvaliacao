using Comuns.Constantes;
using Gazin.Data.Context;
using Gazin.Data.Repository;
using Gazin.Domain.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Gazin.Domain.Repository;
using Gazin.Data.Implementations;

namespace Gazin.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IDesenvolvedorRepository, DesenvolvedorImplementation>();

            serviceCollection.AddDbContext<MyContext>
            (
                options => options.UseSqlServer(Banco.CaminhoBanco())
            );
        }
    }
}
