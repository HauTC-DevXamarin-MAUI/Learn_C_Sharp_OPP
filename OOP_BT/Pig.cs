using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class Pig:FarmmingAnimal
    {
        public Pig()
        {
            Name = Constant.PIG_NAME;
            EatFood = new Bran();
        }
    }
}
