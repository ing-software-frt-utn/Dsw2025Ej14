namespace __Dsw2025Ej14.Api__.__Domain__
{
    public class Product
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal CurrentUnitPrice { get; set; }
        public bool IsActive { get; set; }

        public Product(string sku, string name, decimal currentUnitPrice, bool isActive)
        {
            Sku = sku;
            Name = name;
            CurrentUnitPrice = currentUnitPrice;
            IsActive = isActive;
        }

    }

}
