using System;
using System.Collections.Generic;
using System.IO;

namespace logica2.Models
{
    public class Usuario
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        private string Senha { get; set; }

        private const string PATH = "DataBase/Participante.csv";
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

        public List<string> ReadAllLinesCSV(string PATH)
        {
            List<string> linhas = new List<string>();

            using (StreamReader file = new StreamReader(PATH))
            {
                string linha;
                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
                return linhas;
            }
        }

        public void Criar(Usuario u)
        {

            string[] linha = { PrepararLinha(u) };
            File.AppendAllLines(PATH, linha);
        }

        public string PrepararLinha(Usuario u)
        {
            return $"{u.Nome};{u.Email};{u.Senha}";
        }

        public bool Logar(string email, string senha)
        {
            List<string> csv = ReadAllLinesCSV("DataBase/Participantes.csv");
            var Logado = csv.Find(
                x =>
                x.Split(";")[1] == email && 
                x.Split(";")[2] == senha 


            );
        }
    }
}
