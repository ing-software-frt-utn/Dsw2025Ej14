using System.Text.Json;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        public List<Product> Products { get; set; } = new List<Product>();


        private void LoadProducts()
        {
            var json = File.ReadAllText("Data\\Products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions)
            {

            } ?? new List<Product>();

        }
    }
}


