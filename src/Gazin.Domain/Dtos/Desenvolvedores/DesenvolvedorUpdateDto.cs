using System;
using System.ComponentModel.DataAnnotations;

namespace Gazin.Domain.Dtos.Desenvolvedores
{
    public class DesenvolvedorUpdateDto
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sexo é um campo obrigatório")]
        public char Sexo { get; set; }

        [Required(ErrorMessage = "Idade é um campo obrigatório")]
        public int Idade { get; set; }
        public string Hobby { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é um campo obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

    }
}
