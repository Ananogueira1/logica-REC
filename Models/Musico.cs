using System;

namespace logica2.Models
{

    public class Musico : Usuario
    {
        public string OMB { get; set; }

        private const string Caminho = "DataBase/Musico.csv";

        public Musico()
        {
            CriarPastaArquivos(Caminho);
        }
    }
}