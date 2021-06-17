using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    class Program
    {
        static void Main(string[] args)
        {
            FarmmingController controller = new FarmmingController();
            while (true)
            {
                controller.Menu();
                controller.UserCommand();
            }
            Console.ReadLine();
        }
    }
}
