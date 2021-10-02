using System;
using System.ComponentModel.DataAnnotations;

namespace Gazin.Domain.Dtos.Desenvolvedores
{
    public class DesenvolvedorDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public string Hobby { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataHoraInclusao { get; set; }

    }
}
