using AutoMapper;
using Gazin.Domain.Dtos.Desenvolvedores;
using Gazin.Domain.Entities;

namespace Gazin.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<DesenvolvedorModel, DesenvolvedorDto>()
                .ReverseMap();
            CreateMap<DesenvolvedorModel, DesenvolvedorCreateDto>()
                .ReverseMap();
            CreateMap<DesenvolvedorModel, DesenvolvedorUpdateDto>()
                .ReverseMap();

        }
    }
}
