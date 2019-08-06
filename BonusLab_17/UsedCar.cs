using System;
namespace BonusLab_17
{
    public class UsedCar : Car
    {
        public double Milage { get; set; }

        public UsedCar(int year, string make, string model, double price, double milage)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Milage = milage;
        }

        public override string ToString()
        {
            return (this.Make + "\t" + this.Model + "\t" + this.Year + "\t" + String.Format("{0:C}", this.Price) + "(Used) " + String.Format("{0:n}", this.Milage) + " miles");
        }
    }
}
