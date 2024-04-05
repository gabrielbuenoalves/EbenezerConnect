using Microsoft.AspNetCore.Mvc;
using EbenezerConnect.Services;
using EbenezerConnect.Data.Entidades;

namespace EbenezerConnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Eb_Products> products = _productService.GetProducts();
            return Ok(products);
        }

        // GET: api/user/{id}
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            Eb_Products product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok(product);
        }

        // POST: api/user
        [HttpPost]
        public IActionResult CreateProduct(string productName, decimal productPrice)
        {
            _productService.CreateProduct(productName, productPrice);
            return Ok("Produto criado com sucesso!");
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, string productName, decimal productPrice)
        {
            bool result = _productService.UpdateProduct(id, productName, productPrice);
            if (!result)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok("Produto atualizado com sucesso!");
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            bool result = _productService.DeleteProduct(id);
            if (!result)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok("Produto excluído com sucesso!");
        }
    }
}
