﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class ShoppingCartItem
    {
        //Call Product class { get; set; }
        // int Quantity { get; set; }

        private Product _product;
        private int _quantity;

        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public void SetProduct(Product product)
        {
            _product = product;
        }
        
        public int GetQuantity(int quantity)
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
    }
}
