using Dsw2025Ej14.Api.Domain;
using System.Text.Json;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria
    {

        private List<Product> _products = [];

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }
        public Product? GetProductBySku(string sku)
        {
            return _products.FirstOrDefault(p => p.Sku == sku && p.IsActive);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products.Where(p => p.IsActive);
        }
        private void LoadProducts()
        {
            var json =  File.ReadAllText("products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json);

            
        }

    }
}
