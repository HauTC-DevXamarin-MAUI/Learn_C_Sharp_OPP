using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Rabbit(5, 10);//Animal a = new Rabbit
            a.Run();
            a.Show(); //Co override
            Console.WriteLine("------------------");
            Animal b = new Dragon(10,100); //Animal b = new Dragon
            b.Run();
            b.Show();//khong Co override
            Console.WriteLine("------------------");
            Dragon c = new Dragon(10, 100); //Dragon c = new Dragon
            c.Run();
            c.Show();
            Console.ReadLine();
        }
    }
}
