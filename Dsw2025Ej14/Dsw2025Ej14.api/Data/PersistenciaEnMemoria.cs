using Dsw2025Ej14.Api.Domain;
using System.Collections;
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

        private void LoadProducts()
        {

            var json = File.ReadAllText("Data\\products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? [];


        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _products.Where(p => p.IsActive);
        }

        public Product? GetBySku(string sku)
        {
            return _products.FirstOrDefault(p => p.Sku == sku);
        }
    }
}
