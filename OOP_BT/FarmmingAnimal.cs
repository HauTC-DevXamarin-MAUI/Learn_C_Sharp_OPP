using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class FarmmingAnimal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Food eatFood;

        internal Food EatFood
        {
            get { return eatFood; }
            set { eatFood = value; }
        }
    }
}
