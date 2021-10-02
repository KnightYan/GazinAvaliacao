using System.Threading.Tasks;
using Gazin.Domain.interfaces.Services.Desenvolvedor;
using Moq;
using Xunit;

namespace Gazin.Service.Test.Desenvolvedor
{
    public class CreateTeste : DesenvolvedorTeste
    {
        private IDesenvolvedorService _service;
        private Mock<IDesenvolvedorService> _serviceMock;

        [Fact(DisplayName = "É Possivel executar o Método Create.")]
        public async Task Eh_Possivel_Executar_Metodo_Create()
        {
            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.Post(desenvolvedorCreateDto)).ReturnsAsync(desenvolvedorCreateResultDto);
            _service = _serviceMock.Object;

            var result = await _service.Post(desenvolvedorCreateDto);
            Assert.NotNull(result);
            Assert.Equal(NomeDesenvolvedor, result.Nome);
        }
    }
}
