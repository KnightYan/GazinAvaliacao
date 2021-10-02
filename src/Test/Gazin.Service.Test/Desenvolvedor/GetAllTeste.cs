using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gazin.Domain.Dtos.Desenvolvedores;
using Gazin.Domain.interfaces.Services.Desenvolvedor;
using Moq;
using Xunit;

namespace Gazin.Service.Test.Desenvolvedor
{
    public class GetAllTeste : DesenvolvedorTeste
    {
        private IDesenvolvedorService _service;
        private Mock<IDesenvolvedorService> _serviceMock;

        [Fact(DisplayName = "É Possivel Executar o Método GETAll.")]
        public async Task Eh_Possivel_Executar_Metodo_GetAll()
        {
            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(listaDesenvolvedoresDto);
            _service = _serviceMock.Object;

            var result = await _service.GetAll();
            Assert.NotNull(result);
            Assert.True(result.Count() == 10);

            var _listResult = new List<DesenvolvedorDto>();
            _serviceMock = new Mock<IDesenvolvedorService>();
            _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(_listResult.AsEnumerable);
            _service = _serviceMock.Object;

            var _resultEmpty = await _service.GetAll();
            Assert.Empty(_resultEmpty);
            Assert.True(_resultEmpty.Count() == 0);
        }
    }
}
