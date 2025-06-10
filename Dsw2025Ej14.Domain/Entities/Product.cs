using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej14.Domain.Entities
{
    public class Product
    {
        private string _sku;
        private string _name;
        private decimal _currentUnitPrice;
        private bool _isActiva;

        public Product()
        {
        }

        public Product(string sku, string name, decimal currentUnitPrice, bool isActiva)
        {
            _sku = sku;
            _name = name;
            _currentUnitPrice = currentUnitPrice;
            _isActiva = isActiva;
        }



    }
}
