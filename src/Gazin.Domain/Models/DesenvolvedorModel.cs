using System;

namespace Gazin.Domain.Entities
{
    public class DesenvolvedorModel
    {
        private Guid id;
        public Guid Id { get => id; set => id = value; }
        private string nome;
        public string Nome { get => nome; set => nome = value; }
        private char sexo;
        public char Sexo { get => sexo; set => sexo = value; }
        private int idade;
        public int Idade { get => idade; set => idade = value; }
        private string hobby;
        public string Hobby { get => hobby; set => hobby = value; }
        private DateTime dataNascimento;
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        private DateTime? dataHoraInclusao;
        public DateTime? DataHoraInclusao
        {
            get { return dataHoraInclusao; }
            set { dataHoraInclusao = value ?? DateTime.UtcNow; }
        }
        private DateTime? dataHoraAlteracao;
        public DateTime? DataHoraAlteracao { get => dataHoraAlteracao; set => dataHoraAlteracao = value; }
    }
}
