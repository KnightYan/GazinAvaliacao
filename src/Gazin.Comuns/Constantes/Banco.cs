using System;
using System.IO;

namespace Comuns.Constantes
{
    public static class Banco
    {
        private static string stringConexao = "Server=(localdb)\\mssqllocaldb;Database=GazinCrud;Trusted_Connection=True;";
        private static string _caminhoBanco;
        public static string CaminhoBanco()
        {
            if (_caminhoBanco == null || _caminhoBanco == "")
                ObtemCaminhoBanco();

            return _caminhoBanco;
        }

        private static void ObtemCaminhoBanco()
        {
            //var caminhoBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GazinDataBase2");
            //_caminhoBanco = string.Format(stringConexao, caminhoBanco);
            _caminhoBanco = stringConexao;
        }
    }
}
