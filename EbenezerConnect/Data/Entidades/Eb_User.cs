using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbenezerConnect.Data.Entidades
{
    [Table("Eb_User")]
    public class Eb_User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
    }
}
