using Microsoft.AspNetCore.Mvc;
using Dsw2025Ej14.Api.Data;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly PersistenciaEnMemoria _repo;

        public ProductsController(PersistenciaEnMemoria repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            var products = _repo.GetActiveProducts();
            if (!products.Any()) return NoContent();
            return Ok(products);
        }

        [HttpGet("{sku}")]
        public ActionResult<Product> GetBySku(string sku)
        {
            var product = _repo.GetBySku(sku);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}