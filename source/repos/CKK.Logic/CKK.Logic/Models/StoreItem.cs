using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class StoreItem
    {
        // int Quantity { get; set; }
        // call Product {get;}
        private Product _product;
        private int _quantity;

        public StoreItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public int GetQuantity(int quantity)
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public Product GetProduct()
        {
            return _product;
        }
            
    }
}
