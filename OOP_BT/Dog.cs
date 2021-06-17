using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class Dog:FarmmingAnimal
    {
        public Dog()
        {
            Name = Constant.DOG_NAME;
            EatFood = new Meat();
        }
    }
}
