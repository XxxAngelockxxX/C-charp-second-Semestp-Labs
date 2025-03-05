using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1._1
{
    internal class Product
    {
        private string _name;
        private decimal _price;
        private int _quantity;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Error name");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ERROR PRICE");
                }
                else
                {
                    _price = value;
                }
            }
        }
        public decimal TotalVelue => _price * _quantity;
        public Product(string name, decimal price, int quantity)
        {
            if (name == null || price <= 0)
            {
                Console.WriteLine("Uncorrect date");
                return;
            }
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        public void Restock(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Can`t be ");
                return;
            }
            _quantity += quantity;
        }

        public void Sell(int quantity)
        {
            if (quantity < 0 || _quantity < quantity)
            {
                Console.WriteLine("Can`t sell it");
                return;
            }
            _quantity -= quantity;
        }

        public string GetInfo()
        {
            return $"Name: {_name} , Price: {_price} , On Sclad: {_quantity} , Total Price {TotalVelue} ";
        }
    }
}
