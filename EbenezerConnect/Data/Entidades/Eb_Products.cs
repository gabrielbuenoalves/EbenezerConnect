using System.ComponentModel.DataAnnotations.Schema;

namespace EbenezerConnect.Data.Entidades
{
    [Table("Eb_Products")]

    public class Eb_Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
