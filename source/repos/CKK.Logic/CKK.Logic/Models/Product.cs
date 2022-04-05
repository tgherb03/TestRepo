﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Product
    {
        // int Id { get; set; }
        // string Name { get; set; }
        // decimal Price { get; set; }

        private int _Id;
        private string _Name;
        private decimal _Price;
        
        public Product(int Id, string Name, decimal Price)
        {
            _Id = Id;
            _Name = Name;
            _Price = Price;
        }
        
        public int GetId(int Id)
        {
            return Id;
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public string GetName(string Name)
        {
            return Name;
        }

        public void SetName(string Name)
        {
            _Name = Name;
        }

        public decimal GetPrice(decimal Price)
        {
            return Price;
        }

        public void SetPrice(decimal Price)
        {
            _Price = Price;
        }
    }
}
