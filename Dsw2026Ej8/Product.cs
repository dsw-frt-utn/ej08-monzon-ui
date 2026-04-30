using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        long _code;
        string _description;
        int _quantity;
        decimal _price;

        public Product(long code, string description, int quantity, decimal price)
        {
            _code = code;
            _description = description;
            _quantity = quantity;
            _price = price;
        }
        public Product()
        { 
        }


        public void setDescription(string description)
        {
            _description = description;
        }

        public void setCode(long code)
        {
            _code = code;
        }
        public void setQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public void setPrice(decimal price)
        {
            _price = price;
        }

        public long getCode()
        {
            return _code;
        }

        public string getDescription()
        {
            return _description;
        }
        
        public int getQuantity()
        {
            return _quantity;
        }

        public decimal getPrice()
        {
            return _price;
        }


    }
}
