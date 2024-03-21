using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31BRentalCarSystem
{
    public class Car : Vehicle
    {
        public int NumberOfDoors {  get; set; }
        public Car(string registrationNum, string make, string model, int year, double rentalPricePerDay, bool available, int numberOfDoors) :
            base(registrationNum, make, model, year, rentalPricePerDay, available)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Number of doors: {NumberOfDoors}";
        }
    }
}
