using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31BRentalCarSystem
{
    public class Truck: Vehicle
    {
      
        public int CargoCapacityInTons { get; set; }
        public Truck(string registrationNum, string make, string model, int year, double rentalPricePerDay, bool available, int cargoCapacityInTons) :
            base(registrationNum, make, model, year, rentalPricePerDay, available)
        {
            CargoCapacityInTons = cargoCapacityInTons;
        }
        public override string GetDetails()
        {
            return base.GetDetails()+$", Cargo capacity: {CargoCapacityInTons}";
        }
    }
}
