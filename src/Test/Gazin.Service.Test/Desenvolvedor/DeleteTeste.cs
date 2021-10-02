using System;
using System.Threading.Tasks;
using Gazin.Domain.interfaces.Services.Desenvolvedor;
using Moq;
using Xunit;

namespace Gazin.Service.Test.Desenvolvedor
{
    public class DeleteTeste : DesenvolvedorTeste
    {
        private IDesenvolvedorService _service;
        private Mock<IDesenvolvedorService> _serviceMock;
        [Fact(DisplayName = "É possível executar método Delete.")]
        public async Task Eh_Possivel_Executar_Metodo_Delete()
        {
            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.Delete(IdDesenvolvedor))
                        .ReturnsAsync(true);
            _service = _serviceMock.Object;

            var deletado = await _service.Delete(IdDesenvolvedor);
            Assert.True(deletado);

            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.Delete(It.IsAny<Guid>()))
                        .ReturnsAsync(false);
            _service = _serviceMock.Object;

            deletado = await _service.Delete(Guid.NewGuid());
            Assert.False(deletado);

        }
    }
}
