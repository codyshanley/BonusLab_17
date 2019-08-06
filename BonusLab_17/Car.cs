using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab_17
{
    public class Car
    {
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public Car()
        {
            this.Year = 2007;
            this.Make = "Chrysler";
            this.Model = "Pacifica";
            this.Price = 3500;
        }

        public Car(int year, string make, string model, double price)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public override string ToString()
        {
            return (this.Make + "\t" + this.Model + "\t" + this.Year + "\t" + String.Format("{0:C}", this.Price));
        }

    }
}