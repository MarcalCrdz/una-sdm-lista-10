namespace OscarFilmeApi.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public int AnoLancamento { get; set; }
        public string Categoria { get; set; }
        public bool Venceu { get; set; }
    }
}
