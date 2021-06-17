using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    //nam giu danh sach tung loai dong vat (Chuong)
    class FarmmingAnimalController
    {
        private List<FarmmingAnimal> animalList;

        internal List<FarmmingAnimal> AnimalList
        {
            get { return animalList; }
            set { animalList = value; }
        }//danh sach chua cac dong vat trong chuong


        public void Add(FarmmingAnimal animal)
        {
            AnimalList.Add(animal);
        }
        public void Remove(FarmmingAnimal animal)
        {
            AnimalList.Remove(animal);
        }

        public float TotalAmout(float weight)
        {
            if (AnimalList.Count > 0)
            {
                return AnimalList[0].EatFood.Amout(weight) * AnimalList.Count;
            }
            else
                return 0;
        }

        public void PrintTotalAmout(float weigt)
        {
            if (AnimalList.Count > 0)
            {
                Console.WriteLine("{0,5} {1,10} | eat | {2,7} {3,10} Kg | spend | {4,10} price",AnimalList.Count,AnimalList[0].Name,weigt*AnimalList.Count,AnimalList[0].EatFood.Name,TotalAmout(weigt));
            }
            else
            {
                Console.WriteLine("khong co gi de in!");
            }
        }

        
    }
}
