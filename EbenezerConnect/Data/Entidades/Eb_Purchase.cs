using System.ComponentModel.DataAnnotations.Schema;

namespace EbenezerConnect.Data.Entidades
{
    [Table("Eb_Purchase")]

    public class Eb_Purchase
    {
        public int PurchaseId { get; set; }
        public int PurchaseUserId { get; set; }
        public DateTime PurchaseData { get; set; }
        public decimal PurchaseSum { get; set; }
        public Eb_User User { get; set; }
        public ICollection<Eb_DtPurchase> DtPurchases { get; set; }
    }
}
