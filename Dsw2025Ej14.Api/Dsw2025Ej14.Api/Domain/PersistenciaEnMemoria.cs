using System.Text.Json;

namespace Dsw2025Ej14.Api.Domain
{
    public class PersistenciaEnMemoria
    {

        private List<Productos> productos;

        public PersistenciaEnMemoria()
        {

            productos = LoadProduct();

        }
        private List<Productos> LoadProduct()
        {

            var json = File.ReadAllText("C:/src/Dsw2025Ej14");
            return  JsonSerializer.Deserialize<List<Productos>>






}



    }
    }
