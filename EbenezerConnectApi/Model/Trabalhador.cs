using System.ComponentModel.DataAnnotations.Schema;

namespace EbenezerConnectApi.Model
{
    public class Trabalhador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Igreja { get; set; }
        public DateTime DataContratacao { get; set; }

        // Chave estrangeira
        public int QuartoId { get; set; }

        // Propriedade de navegação
        [ForeignKey("QuartoId")]
        public Quarto Quarto { get; set; }
    }
}
