using System.ComponentModel.DataAnnotations.Schema;

namespace EbenezerConnectApi.Model
{
    public class Acampante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Igreja { get; set; }
        public DateTime DataInscricao { get; set; }

        // Chave estrangeira
        public int QuartoId { get; set; }

        // Propriedade de navegação
        [ForeignKey("QuartoId")]
        public Quarto Quarto { get; set; }
    }
}
