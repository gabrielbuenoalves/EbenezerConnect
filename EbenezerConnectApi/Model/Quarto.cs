namespace EbenezerConnectApi.Model
{
    public class Quarto
    {
        public int Id { get; set; }
        public string NomeQuarto { get; set; }
        public int Capacidade { get; set; }

        // Propriedades de navegação
        public ICollection<Acampante> Acampantes { get; set; }
        public ICollection<Trabalhador> Trabalhadores { get; set; }
    }
}
