using AutoMapper;
using Gazin.Domain.Entities;

namespace Gazin.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<DesenvolvedorModel, DesenvolvedorEntity>()
               .ReverseMap();
        }
    }
}
