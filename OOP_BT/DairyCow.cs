using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class DairyCow:FarmmingAnimal
    {
        public DairyCow()
        {
            Name = Constant.DAIRY_COW_NAME;
            EatFood = new Grass();
        }
    }
}
