using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class Meat:Food
    {
        public Meat()
        {
            Name = Constant.MEAT_NAME;
            Price = Constant.MEAT_PRICE;
        }
    }
}
