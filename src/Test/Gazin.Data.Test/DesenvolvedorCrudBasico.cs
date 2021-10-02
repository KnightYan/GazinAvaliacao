using System;
using System.Linq;
using System.Threading.Tasks;
using Gazin.Data.Context;
using Gazin.Data.Implementations;
using Gazin.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Gazin.Data.Test
{
    public class DesenvolvedorCrudBasico : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvide;

        public DesenvolvedorCrudBasico(DbTeste dbTeste)
        {
            _serviceProvide = dbTeste.ServiceProvider;
        }


        [Fact(DisplayName = "CRUD de Desenvolvedor")]
        [Trait("CRUD", "DesenvolvedorEntity")]
        public async Task Eh_Possivel_Realizar_CRUD_Basico()
        {
            using (var context = _serviceProvide.GetService<MyContext>())
            {
                DesenvolvedorImplementation _repositorio = new DesenvolvedorImplementation(context);
                DesenvolvedorEntity _entity = new DesenvolvedorEntity
                {
                    Nome = Faker.Name.FullName(),
                    DataNascimento = Faker.DateOfBirth.Next(),
                    Sexo = 'M',
                    Idade = 1,
                    Hobby = "Esporte"
                };

                var _registroCriado = await _repositorio.InsertAsync(_entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal(_entity.DataNascimento, _registroCriado.DataNascimento);
                Assert.Equal(_entity.Nome, _registroCriado.Nome);
                Assert.Equal(_entity.Sexo, _registroCriado.Sexo);
                Assert.Equal(_entity.Idade, _registroCriado.Idade);
                Assert.Equal(_entity.Hobby, _registroCriado.Hobby);
                Assert.False(_registroCriado.Id == Guid.Empty);

                _entity.Nome = Faker.Name.First();
                var _registroAtualizado = await _repositorio.UpdateAsync(_entity);
                Assert.NotNull(_registroAtualizado);
                Assert.Equal(_entity.Nome, _registroAtualizado.Nome);

                var _registroExiste = await _repositorio.ExistAsync(_registroAtualizado.Id);
                Assert.True(_registroExiste);

                var _registroSelecionado = await _repositorio.SelectAsync(_registroAtualizado.Id);
                Assert.NotNull(_registroSelecionado);
                Assert.Equal(_registroAtualizado.Nome, _registroSelecionado.Nome);
                Assert.Equal(_registroAtualizado.DataNascimento, _registroSelecionado.DataNascimento);
                Assert.Equal(_registroAtualizado.Sexo, _registroSelecionado.Sexo);
                Assert.Equal(_registroAtualizado.Idade, _registroSelecionado.Idade);
                Assert.Equal(_registroAtualizado.Hobby, _registroSelecionado.Hobby);

                var _todosRegistros = await _repositorio.SelectAsync();
                Assert.NotNull(_todosRegistros);
                Assert.NotEmpty(_todosRegistros);

                var _removeu = await _repositorio.DeleteAsync(_registroSelecionado.Id);
                Assert.True(_removeu);
            }
        }
    }
}
