using Microsoft.AspNetCore.Mvc;

namespace __Dsw2025Ej14.Api__.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
