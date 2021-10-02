using System;
using System.Collections.Generic;
using Gazin.Domain.Dtos.Desenvolvedores;

namespace Gazin.Service.Test.Desenvolvedor
{
    public class DesenvolvedorTeste
    {
        public static string NomeDesenvolvedor { get; set; }
        public static string NomeDesenvolvedorAlterado { get; set; }
        public static Guid IdDesenvolvedor { get; set; }

        public List<DesenvolvedorDto> listaDesenvolvedoresDto = new List<DesenvolvedorDto>();
        public DesenvolvedorDto desenvolvedorDto;
        public DesenvolvedorCreateDto desenvolvedorCreateDto;
        public DesenvolvedorCreateResultDto desenvolvedorCreateResultDto;
        public DesenvolvedorUpdateDto desenvolvedorUpdateDto;
        public DesenvolvedorUpdateResultDto desenvolvedorUpdateResultDto;

        public DesenvolvedorTeste()
        {
            IdDesenvolvedor = Guid.NewGuid();
            NomeDesenvolvedor = Faker.Name.FullName();
            NomeDesenvolvedorAlterado = Faker.Name.FullName();

            for (int i = 0; i < 10; i++)
            {
                var dto = new DesenvolvedorDto()
                {
                    Id = Guid.NewGuid(),
                    Nome = Faker.Name.FullName()
                };
                listaDesenvolvedoresDto.Add(dto);
            }

            desenvolvedorDto = new DesenvolvedorDto
            {
                Id = IdDesenvolvedor,
                Nome = NomeDesenvolvedor
            };

            desenvolvedorCreateDto = new DesenvolvedorCreateDto
            {
                Nome = NomeDesenvolvedor
            };


            desenvolvedorCreateResultDto = new DesenvolvedorCreateResultDto
            {
                Id = IdDesenvolvedor,
                Nome = NomeDesenvolvedor,
                DataHoraInclusao = DateTime.UtcNow
            };

            desenvolvedorUpdateDto = new DesenvolvedorUpdateDto
            {
                Id = IdDesenvolvedor,
                Nome = NomeDesenvolvedorAlterado
            };

            desenvolvedorUpdateResultDto = new DesenvolvedorUpdateResultDto
            {
                Id = IdDesenvolvedor,
                Nome = NomeDesenvolvedorAlterado,
                DataHoraAlteracao = DateTime.UtcNow
            };

        }
    }
}
