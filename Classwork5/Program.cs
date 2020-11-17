using System;
using System.Collections.Generic;

namespace Classwork5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter dice value (e.g. 8d6 like damage from fireball)");
            //string input = Console.ReadLine();
            //var splitInput = input.Split('d');
            //int x = int.Parse(splitInput[0]);
            //int y = int.Parse(splitInput[1]);

            //Console.WriteLine(DiceHelper.ThrowDices(x,y));

            var nyashok = new Cat() { Name = "Nyasha", Weight = 5000, FoodsInFridge = new List<Food>() };

            nyashok.FoodsInFridge.Add(new Food() { Name = "Fish", Weight = 200, Price = 50 });
            nyashok.FoodsInFridge.Add(new Food() { Name = "Meat", Weight = 180, Price = 50 });
            nyashok.FoodsInFridge.Add(new Food() { Name = "Chicken", Weight = 300, Price = 50 });
            nyashok.FoodsInFridge.Add(new Food() { Name = "Bananas", Weight = 500, Price = 50 });

            string answer = string.Empty;
            while(answer!="q")
            {
                Console.WriteLine("What do you want? 1 - feed cat, 2 - greet me, q - quit");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        nyashok.Feed();
                        break;
                    case "2":
                        Console.WriteLine("Hello");
                        break;
                    case "q":
                        continue;
                        
                    default:
                        Console.WriteLine("I dont understand you");
                        break;
                }
            }

        }


    }


}
