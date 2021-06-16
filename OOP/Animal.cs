using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        private int weidth;

        public int Weidth
        {
            get { return weidth; }
            set { weidth = value; }
        }
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

         virtual public void Run()
        {
            Console.WriteLine("Animal is runnning...");
        }
         public Animal(int weidth,int speed)
        {
            Weidth = weidth;
            Speed = speed;
        }
         virtual public void Show()
        {
            Console.WriteLine("Animal: {0}|{1}",Weidth,Speed);
        }
        //ttinh tru tuong:
         //abstract void Sleep();
        //K dc dinh nghia cho body (sleep)//khai khai bao class Animal thanh abstract //thang nao ke thua(Animal co abstract) thi phai dih nghia n Sleep
         
    }
}
