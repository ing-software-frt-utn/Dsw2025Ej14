namespace Dsw2025Ej14.Api.Data

{
    using System.Text.Json;
    using Dsw2025Ej14.Api.Domain;
    public class PersistenciaEnMemoria
    {
        public List<Product> ListaDeProductos { get; set; }
        


        public PersistenciaEnMemoria() {

           
        }

        public void LoadsProducts() {

            var Taskjson =  File.ReadAllText("Data\\products.json");


            ListaDeProductos = JsonSerializer.Deserialize<List<Product>>(Taskjson, new JsonSerializerOptions
            {


                PropertyNameCaseInsensitive = true,
            }) ?? [];

        }

    }
}
