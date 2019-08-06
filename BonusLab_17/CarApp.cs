using System;
using System.Collections.Generic;
namespace BonusLab_17
{
    public class CarApp
    {
        List<Car> cars = new List<Car>();

        public CarApp()
        {
        }

        public void FillList()
        {
            cars.Add(new Car(2019, "Tesla", "Model 3", 35000));
            cars.Add(new Car(2017, "Suburu", "Outback", 32000));
            cars.Add(new Car(2020, "Ford", "F-150", 34000));
            cars.Add(new UsedCar(2012, "Volvo", "XC70", 14000, 230000));
            cars.Add(new UsedCar(2007, "Audi", "R8", 90000, 190000));
            cars.Add(new UsedCar(2001, "Saab", "9-5t", 8000, 140000));
        }

        public void PrintCars()
        {
            Console.WriteLine("Current Inventory:");

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + cars[i].ToString());
            }
        }

        public void GetInput()
        {
            Console.Write("Which car would you like?: ");
            int carNum = int.Parse(Console.ReadLine());

            Console.WriteLine(cars[carNum - 1].ToString());

            Console.Write("Would you like to buy this car? (y/n): ");
            string response = Console.ReadLine().ToLower();

            if (response == "y")
            {
                cars.Remove(cars[carNum - 1]);
                Console.WriteLine("Excellent! Our finance department will be in touch shortly.");
            }
            
        }
    }
}