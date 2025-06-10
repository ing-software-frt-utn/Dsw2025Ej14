using Dsw2025Ej14.Api.Data;
using Dsw2025Ej14.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly PersistenciaEnMemoria _persistencia;

        public ProductsController(PersistenciaEnMemoria persistencia)
        {
            _persistencia = persistencia;
        }

        [HttpGet]
        public IActionResult GetActiveProducts()
        {
            var products = _persistencia.GetActiveProducts().ToList();

            if (products == null || products.Count == 0)
            {
                return NoContent();
            }

            return Ok(products);
        }

        [HttpGet("{sku}")]
        public IActionResult GetBySku(string sku)
        {
            var product = _persistencia.GetBySku(sku);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
