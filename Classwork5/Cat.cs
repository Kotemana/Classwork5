using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork5
{
    public class Cat
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public List<Food> FoodsInFridge { get; set; }

        public bool IsDead { get; set; }

        public void Feed()
        {
            if (IsDead)
            {
                Console.WriteLine("The cat is dead already, leave it away");
                return;
            }
            var foodWeight = Weight / 10;
            var foodFed = 0;
            Console.WriteLine($"{Name} needs {foodWeight} gramms of food");
            var random = new Random();
            while (foodFed < foodWeight)
            {
                if (FoodsInFridge.Count == 0)
                {
                    Console.WriteLine($"{Name} has nothing to eat and dies");
                    IsDead = true;
                    break;
                }
                var foodTaken = FoodsInFridge[random.Next(FoodsInFridge.Count)];
                foodFed += foodTaken.Weight;
                Console.WriteLine($"{Name} ate {foodTaken.Name} of {foodTaken.Weight} gramms, total food eaten: {foodFed}");
                FoodsInFridge.Remove(foodTaken);
            }
            
            Weight += foodWeight / 2;
        }

        

    }
}
