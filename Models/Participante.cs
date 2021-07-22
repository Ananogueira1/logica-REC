namespace logica2.Models
{
    public class Participante : Usuario
    {
        // idade
        public int Idade { get; set; }
        public bool Acompanhante { get; set; }

        private const string Caminho ="DataBase/Participante.csv";

        public Participante()
        {
            CriarPastaArquivos(Caminho);
        }
    }
}