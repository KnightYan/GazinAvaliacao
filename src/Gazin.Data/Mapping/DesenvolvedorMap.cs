using Microsoft.EntityFrameworkCore;
using Gazin.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gazin.Data.Mapping
{
    public class DesenvolvedorMap : IEntityTypeConfiguration<DesenvolvedorEntity>
    {
        public void Configure(EntityTypeBuilder<DesenvolvedorEntity> builder)
        {
            builder.ToTable("Desenvolvedor");
            builder.HasKey(p => p.Id);
        }
    }
}
