using EbenezerConnect.Data;
using EbenezerConnect.Data.Entidades;

namespace EbenezerConnect.Services
{
    public class ProductService
    {
        public void CreateProduct(string productName, decimal productPrice)
        {
            var context = new Connection();
            var product = new Eb_Products
            {
                ProductName = productName,
                ProductPrice = productPrice
            };
            try
            {
                context.Eb_Products.Add(product);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao adicionar o novo produto: {ex.Message}");
            }
        }

        public List<Eb_Products> GetProducts()
        {
            var context = new Connection();
            return context.Eb_Products.ToList();
        }

        public Eb_Products GetProductById(int id)
        {
            var context = new Connection();
            return context.Eb_Products.Find(id);
        }

        public bool UpdateProduct(int id, string productName, decimal productPrice)
        {
            var context = new Connection();
            var product = context.Eb_Products.Find(id);
            if (product == null)
            {
                return false; // Retorna falso se o usuário não for encontrado
            }

            product.ProductName = productName;
            product.ProductPrice = productPrice;
            context.SaveChanges();
            return true; // Retorna verdadeiro se o usuário for atualizado com sucesso
        }


        public bool DeleteProduct(int id)
        {
            var context = new Connection();
            var product = context.Eb_Products.Find(id);
            if (product == null)
            {
                return false; // Retorna falso se o usuário não for encontrado
            }

            context.Eb_Products.Remove(product);
            context.SaveChanges();
            return true; // Retorna verdadeiro se o usuário for excluído com sucesso
        }
    }
}
