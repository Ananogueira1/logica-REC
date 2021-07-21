using System;
using System.IO;

namespace logica2.Models
{
    public class Usuario
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        private string Senha { get; set; }

        public void CriarPastaArquivos(string _path)
        {
            string pasta = _path.Split("/")[0];
            string arquivo = _path.Split("/")[1];
            
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(_path))
            {
                File.Create(_path).Close();
            }
        }
        public string CadastrarUsuario()
        {

        }
    }
}