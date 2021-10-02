using AutoMapper;
using Gazin.Domain.Dtos.Desenvolvedores;
using Gazin.Domain.Entities;

namespace Gazin.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<DesenvolvedorDto, DesenvolvedorEntity>()
               .ReverseMap();

            CreateMap<DesenvolvedorCreateResultDto, DesenvolvedorEntity>()
               .ReverseMap();

            CreateMap<DesenvolvedorUpdateResultDto, DesenvolvedorEntity>()
               .ReverseMap();

        }
    }
}
