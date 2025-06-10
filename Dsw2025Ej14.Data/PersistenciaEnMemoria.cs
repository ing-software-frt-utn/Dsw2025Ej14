using System.Text.Json;
using Dsw2025Ej14.Domain;

namespace Dsw2025Ej14.Data;
public class PersistenciaEnMemoria: IPersistenci
{
    private readonly string Archivo = "products.json";
    private List<Product> _products = [];
    public PersistenciaEnMemoria()
    {
        LoadProducts();
    }
    private void LoadProducts()
    {
        try
        {
            _products = JsonSerializer.Deserialize<List<Product>>(Archivo) ?? new List<Product>();
        } catch(Exception ex) 
        {
            
        }

    }

    public List<Product> GetProducts() => _products;









}

