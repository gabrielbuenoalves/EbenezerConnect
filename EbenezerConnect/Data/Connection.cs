using EbenezerConnect.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EbenezerConnect.Data
{
    public class Connection : DbContext
    {
    public DbSet<Eb_User> Eb_User { get; set; } // Torna a propriedade pública
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionstring = "server=localhost;port=3306;database=ebenezerconnect;uid=root;password=admin";
                optionsBuilder.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring));            }
        }
    }
}
