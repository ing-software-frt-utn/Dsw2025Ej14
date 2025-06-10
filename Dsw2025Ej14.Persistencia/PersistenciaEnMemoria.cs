using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Dsw2025Ej14.Domain.Entities;

namespace Dsw2025Ej14.Persistencia
{
    public class PersistenciaEnMemoria
    {
        private const string Archivo = "products.json";
        private List<Product> _products = [];

       
        protected void LoadProducts(string Archivo)
        {
            
            var json = File.ReadAllLines(Archivo);
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }); ??[];
        }

    }
}
