using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class Chiecken:FarmmingAnimal
    {
        public Chiecken()
        {
            Name = Constant.CHICKEN_NAME;
            EatFood = new Corn();
        }
    }
}
