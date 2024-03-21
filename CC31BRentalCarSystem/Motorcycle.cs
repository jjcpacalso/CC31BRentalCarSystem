using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31BRentalCarSystem
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar {  get; set; }
        public Motorcycle(string registrationNum, string make, string model, int year, double rentalPricePerDay, bool available, bool hasSideCar) : base(registrationNum, make, model, year, rentalPricePerDay, available)
        {
            HasSideCar = hasSideCar;
        }
        public override string GetDetails()
        {
            return base.GetDetails()+$", has a side car";
        }
    }
}
