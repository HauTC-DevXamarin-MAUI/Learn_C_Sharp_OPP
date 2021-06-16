using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dragon:Animal,IDontKnow
    {
        public void Fly()
        {
            Console.WriteLine("Dragon is Flying..");
        }

        public Dragon(int weidth, int speed):base(weidth,speed)
        {
 
        }
        public void Show()//k co override
        {
            Console.WriteLine("Dragon: {0}|{1}", Weidth, Speed);
        }

        public void Eat()//Dinh ngia cho Eat() ben interface
        { }
        public int Meat
        {
            get;
            set;
        }
    }
}
