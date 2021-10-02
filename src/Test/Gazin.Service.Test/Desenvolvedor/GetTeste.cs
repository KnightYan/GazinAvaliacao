using System;
using System.Threading.Tasks;
using Gazin.Domain.Dtos.Desenvolvedores;
using Gazin.Domain.interfaces.Services.Desenvolvedor;
using Moq;
using Xunit;

namespace Gazin.Service.Test.Desenvolvedor
{
    public class GetTeste : DesenvolvedorTeste
    {
        private IDesenvolvedorService _service;
        private Mock<IDesenvolvedorService> _serviceMock;

        [Fact(DisplayName = "É Possivel Executar o Método GET.")]
        public async Task Eh_Possivel_Executar_Metodo_Get()
        {
            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.GetTask(IdDesenvolvedor)).ReturnsAsync(desenvolvedorDto);
            _service = _serviceMock.Object;

            var result = await _service.GetTask(IdDesenvolvedor);
            Assert.NotNull(result);
            Assert.True(result.Id == IdDesenvolvedor);
            Assert.Equal(NomeDesenvolvedor, result.Nome);

            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.GetTask(It.IsAny<Guid>())).Returns(Task.FromResult((DesenvolvedorDto)null));
            _service = _serviceMock.Object;

            var _record = await _service.GetTask(IdDesenvolvedor);
            Assert.Null(_record);

        }
    }
}
