using Comuns.Constantes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gazin.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {

        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = Banco.CaminhoBanco();
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
