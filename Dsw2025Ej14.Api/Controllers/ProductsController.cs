using Dsw2025Ej14.Api;
using Dsw2025Ej14.Data;
using Dsw2025Ej14.Domain;
using Microsoft.AspNetCore.Mvc;


namespace Dsw2025Ej14.Api.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private IPersistenci _persistenci;

        public ProductsController(IPersistenci persistenci)
        {
            _persistenci = persistenci;
        }
        [HttpGet(Name = "api/products")]
        public IEnumerable<Product> GetProducts()
        {
            return _persistenci.GetProducts().AsEnumerable<Product>();
        }
    }

}
