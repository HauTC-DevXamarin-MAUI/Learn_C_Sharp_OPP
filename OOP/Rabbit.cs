using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Rabbit:Animal
    {
        public void Jump()
        {
            Console.WriteLine("Rabbit is jumpping...");
        }
        
        public override void Show()
        {
            Console.WriteLine("Rabbit: {0}|{1}", Weidth, Speed);
        }
        public Rabbit(int weidth, int speed)
            : base(weidth, speed)
        {

        }

    }
}
