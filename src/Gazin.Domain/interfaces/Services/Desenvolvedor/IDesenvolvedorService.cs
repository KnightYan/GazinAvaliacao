using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gazin.Domain.Dtos.Desenvolvedores;

namespace Gazin.Domain.interfaces.Services.Desenvolvedor
{
    public interface IDesenvolvedorService
    {
        Task<DesenvolvedorDto> GetTask(Guid id);
        Task<IEnumerable<DesenvolvedorDto>> GetAll();
        Task<DesenvolvedorCreateResultDto> Post(DesenvolvedorCreateDto desenvolvedor);
        Task<DesenvolvedorUpdateResultDto> Put(DesenvolvedorUpdateDto desenvolvedor);
        Task<bool> Delete(Guid id);
    }
}
