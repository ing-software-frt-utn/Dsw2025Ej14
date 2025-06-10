namespace Dsw2025Ej14.Api.Domain
{
    public class Product
    {
        private string Sku;
        private string name;
        private decimal CurrentUnitPrince;
        private bool IsActive;

        public string SKU
        {
            get { return Sku; }
            set { Sku = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal CurrentUnitPrice
        {
            get { return CurrentUnitPrince; }
            set { CurrentUnitPrince = value; }
        }

        public bool IsActiveProperty
        {
            get { return IsActive; }
            set { IsActive = value; }
        }
    }


}
