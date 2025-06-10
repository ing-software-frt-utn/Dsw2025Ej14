using Dsw2025Ej14.Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly PersistenciaEnMemoria _persistencia;
        public ProductsController(PersistenciaEnMemoria persistencia)
        {
            _persistencia = persistencia;
        }

        // GET: ProductsController
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _persistencia.GetProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("{sku}")]

        public IActionResult GetProductBySku(string sku)
        {
            var product = _persistencia.GetProductBySku(sku);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // GET: ProductsController/Details/5
       

        //// GET: ProductsController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProductsController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductsController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductsController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductsController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductsController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
