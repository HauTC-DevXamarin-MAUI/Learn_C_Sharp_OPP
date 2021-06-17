using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class Food
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public float Amout(float weightt)
        {
            return Price * weightt;
        }
    }
}
