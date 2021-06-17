using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BT
{
    //nam giu danh sach FarmmingAnimalController
    class FarmmingController
    {
        //tao cac chuong
        private FarmmingAnimalController dairyCow;
        internal FarmmingAnimalController DairyCow
        {
            get { return dairyCow; }
            set { dairyCow = value; }
        }
        private FarmmingAnimalController pig;
        internal FarmmingAnimalController Pig
        {
            get { return pig; }
            set { pig = value; }
        }
        private FarmmingAnimalController chicken;
        internal FarmmingAnimalController Chicken
        {
            get { return chicken; }
            set { chicken = value; }
        }
        private FarmmingAnimalController dog;
        internal FarmmingAnimalController Dog
        {
            get { return dog; }
            set { dog = value; }
        }

        //ham dung
        public FarmmingController()
        {
            DairyCow = new FarmmingAnimalController();
            Pig = new FarmmingAnimalController();
            Dog = new FarmmingAnimalController();
            Chicken = new FarmmingAnimalController();
        }

        public void Menu()
        {
            string menu = "1. Total Amout."
                + Environment.NewLine
                + "Remove animal: Remove <Animal code> <Amout>."
                + Environment.NewLine
                + "\t1: Dairy Cow | 2: Chicken | 3: Pig | 4: Dog"
                + Environment.NewLine
                + "Add animal: Add <Animal code> <Amout>."
                + Environment.NewLine
                + "\t1: Dairy Cow | 2: Chicken | 3: Pig | 4: Dog";

            Console.WriteLine(menu);
        }
        
        private void Remove(FarmmingAnimalController animalController, string name, int number)
        {
            if (animalController.AnimalList.Count >= number)
            {
                FarmmingAnimal newAnimal = new FarmmingAnimal();
                if (name.Equals(Constant.DAIRY_COW_NAME))
                {
                    newAnimal = new DairyCow();
                }
                else
                    if (name.Equals(Constant.PIG_NAME))
                    {
                        newAnimal = new Pig();
                    }
                    else
                        if (name.Equals(Constant.CHICKEN_NAME))
                        {
                            newAnimal = new Chiecken();
                        }
                        else
                            if (name.Equals(Constant.DOG_NAME))
                            {
                                newAnimal = new Dog();
                            }
                            else return;
                for (int i = 0; i < number; i++)
                {
                    animalController.Remove(newAnimal);
                }
            }
            else 
            {
                animalController.AnimalList.Clear(); 
            }
        }
        private void Add(FarmmingAnimalController animalController, string name, int number)
        {
            FarmmingAnimal newAnimal = new FarmmingAnimal();
            if (name.Equals(Constant.DAIRY_COW_NAME))
            {
                newAnimal = new DairyCow();
            }
            else
                if (name.Equals(Constant.PIG_NAME))
                {
                    newAnimal = new Pig();
                }
                else
                    if (name.Equals(Constant.CHICKEN_NAME))
                    {
                        newAnimal = new Chiecken();
                    }
                    else
                        if (name.Equals(Constant.DOG_NAME))
                        {
                            newAnimal = new Dog();
                        }
                        else return;
            for (int i = 0; i < number; i++)
            {
                animalController.Add(newAnimal);
            }
        }

        public void AddAnimal(string animalName, int amout)
        {
            if (animalName.Equals(Constant.DAIRY_COW_NAME))
            {
                Add(DairyCow,Constant.DAIRY_COW_NAME,amout);
                return;
            }
            if (animalName.Equals(Constant.CHICKEN_NAME))
            {
                Add(DairyCow,Constant.CHICKEN_NAME,amout);
                return;
            }
            if (animalName.Equals(Constant.PIG_NAME))
            {
                Add(DairyCow,Constant.PIG_NAME,amout);
                return;
            }
            if (animalName.Equals(Constant.DOG_NAME))
            {
                Add(DairyCow, Constant.DOG_NAME, amout);
                return;
            }
            
        }
        public void RemoveAnimal(string animalName, int amout)
        {
            if (animalName.Equals(Constant.DAIRY_COW_NAME))
            {
                Remove(DairyCow, Constant.DAIRY_COW_NAME, amout);
                return;
            }
            if (animalName.Equals(Constant.CHICKEN_NAME))
            {
                Remove(DairyCow, Constant.CHICKEN_NAME, amout);
                return;
            }
            if (animalName.Equals(Constant.PIG_NAME))
            {
                Remove(DairyCow, Constant.PIG_NAME, amout);
                return;
            }
            if (animalName.Equals(Constant.DOG_NAME))
            {
                Remove(DairyCow, Constant.DOG_NAME, amout);
                return;
            }

        }

        public void UserCommand()
        {
            //FarmmingAnimalController ctr = new FarmmingAnimalController();
            //int command = int.Parse(Console.ReadLine());
            //int sum = 0;
            ////switch (1)
            ////{case
            ////    default:
            ////        break;
            ////}
        }

        public void TotalAmout()
        {
            float sum = DairyCow.TotalAmout(Constant.FOOD_WEIGHT_DAIRY_COW_EAT_PER_DAY)
                + Chicken.TotalAmout(Constant.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY)
                + Dog.TotalAmout(Constant.FOOD_WEIGHT_DOG_EAT_PER_DAY)
                + Pig.TotalAmout(Constant.FOOD_WEIGHT_PIG_EAT_PER_DAY);

            DairyCow.PrintTotalAmout(Constant.FOOD_WEIGHT_DAIRY_COW_EAT_PER_DAY);
            Chicken.PrintTotalAmout(Constant.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY);
            Dog.PrintTotalAmout(Constant.FOOD_WEIGHT_DOG_EAT_PER_DAY);
            Pig.PrintTotalAmout(Constant.FOOD_WEIGHT_PIG_EAT_PER_DAY);
            Console.WriteLine("\nTotal:{0,10} price",sum);
        }
    }
}
