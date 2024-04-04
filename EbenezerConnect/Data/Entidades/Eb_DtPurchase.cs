using System.ComponentModel.DataAnnotations.Schema;

namespace EbenezerConnect.Data.Entidades
{
    [Table("Eb_DtPurchase")]
    public class Eb_DtPurchase
    {
        public int DtPurchaseId { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int DtPurchaseAmount { get; set; }
        public decimal DtPurchasePartial { get; set; }
        public Eb_Purchase Purchase { get; set; }
        public Eb_Products Product { get; set; }
    }
}
