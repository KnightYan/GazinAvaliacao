using Gazin.Data.Mapping;
using Gazin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gazin.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<DesenvolvedorEntity> Desenvolvedor { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DesenvolvedorEntity>(new DesenvolvedorMap().Configure);
        }
    }
}
