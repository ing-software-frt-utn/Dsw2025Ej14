using Dsw2025Ej14.Api.Data;
using Dsw2025Ej14.Api.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Dsw2025Ej14.Api.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IPersistencia _persistencia;
        public ProductsController(IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }
        [HttpGet("api/products")]
        public IActionResult GetProducts()
        {
            var products = _persistencia.GetProducts();
            _persistencia.LoadProducts();
            return Ok(_persistencia.GetProducts());
        }
        [HttpGet("api/products/{sku}")]
        public IActionResult GetProduct(string sku)
        {
            return Ok(_persistencia.GetProduct(sku));
        }
    }
}
