using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public interface IPersistencia
    {
        public void LoadProducts();
        public List<Product> GetProducts();
    }
}
