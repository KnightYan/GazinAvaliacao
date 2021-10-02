using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gazin.Domain.Dtos.Desenvolvedores;
using Gazin.Domain.Entities;
using Gazin.Domain.interfaces;
using Gazin.Domain.interfaces.Services.Desenvolvedor;

namespace Gazin.Service.Service
{
    public class DesenvolvedorService : IDesenvolvedorService
    {
        private IRepository<DesenvolvedorEntity> _repository;
        private readonly IMapper _mapper;
        public DesenvolvedorService(IRepository<DesenvolvedorEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DesenvolvedorDto>> GetAll()
        {
            var resultList = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<DesenvolvedorDto>>(resultList);
        }

        public async Task<DesenvolvedorDto> GetTask(Guid id)
        {
            var result = await _repository.SelectAsync(id);
            return _mapper.Map<DesenvolvedorDto>(result) ?? new DesenvolvedorDto();
        }

        public async Task<DesenvolvedorCreateResultDto> Post(DesenvolvedorCreateDto desenvolvedor)
        {
            var model = _mapper.Map<DesenvolvedorModel>(desenvolvedor);
            var entity = _mapper.Map<DesenvolvedorEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<DesenvolvedorCreateResultDto>(result);
        }

        public async Task<DesenvolvedorUpdateResultDto> Put(DesenvolvedorUpdateDto desenvolvedor)
        {
            var model = _mapper.Map<DesenvolvedorModel>(desenvolvedor);
            var entity = _mapper.Map<DesenvolvedorEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<DesenvolvedorUpdateResultDto>(result);
        }
    }
}
