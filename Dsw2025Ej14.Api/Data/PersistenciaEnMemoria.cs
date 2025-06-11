using System.Text.Json;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria
    {
        private List<Product> _products = new();

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            var json = File.ReadAllText("products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json);
            if (products != null)
                _products = products;
        }

        public List<Product> GetActiveProducts() => _products.Where(p => p.IsActive).ToList();
        public Product? GetBySku(string sku) => _products.FirstOrDefault(p => p.Sku == sku);
    }
}