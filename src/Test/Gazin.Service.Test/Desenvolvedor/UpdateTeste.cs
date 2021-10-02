using System.Threading.Tasks;
using Gazin.Domain.interfaces.Services.Desenvolvedor;
using Moq;
using Xunit;

namespace Gazin.Service.Test.Desenvolvedor
{
    public class UpdateTeste : DesenvolvedorTeste
    {
        private IDesenvolvedorService _service;
        private Mock<IDesenvolvedorService> _serviceMock;

        [Fact(DisplayName = "É Possivel executar o Método Update.")]
        public async Task Eh_Possivel_Executar_Metodo_Update()
        {
            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.Post(desenvolvedorCreateDto)).ReturnsAsync(desenvolvedorCreateResultDto);
            _service = _serviceMock.Object;

            var result = await _service.Post(desenvolvedorCreateDto);
            Assert.NotNull(result);
            Assert.Equal(NomeDesenvolvedor, result.Nome);

            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.Put(desenvolvedorUpdateDto)).ReturnsAsync(desenvolvedorUpdateResultDto);
            _service = _serviceMock.Object;

            var resultUpdate = await _service.Put(desenvolvedorUpdateDto);
            Assert.NotNull(resultUpdate);
            Assert.Equal(NomeDesenvolvedorAlterado, resultUpdate.Nome);

        }
    }
}
