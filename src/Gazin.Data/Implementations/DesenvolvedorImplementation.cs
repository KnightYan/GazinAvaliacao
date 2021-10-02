using Gazin.Data.Context;
using Gazin.Data.Repository;
using Gazin.Domain.Entities;
using Gazin.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Gazin.Data.Implementations
{
    public class DesenvolvedorImplementation : BaseRepository<DesenvolvedorEntity>, IDesenvolvedorRepository
    {
        private DbSet<DesenvolvedorEntity> _dataset;
        public DesenvolvedorImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<DesenvolvedorEntity>();
        }
    }
}
