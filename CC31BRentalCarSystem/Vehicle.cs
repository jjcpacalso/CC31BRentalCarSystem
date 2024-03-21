using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31BRentalCarSystem
{
    public class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double RentalPricePerDay { get; set; }
        public bool Available { get; set; }

        public Vehicle(string registrationNum, string make, string model, int year, double rentalPricePerDay, bool available)
        {
            RegistrationNumber = registrationNum;
            Make = make;
            Model = model;
            Year = year;
            RentalPricePerDay = rentalPricePerDay;
            Available = available;
        }

        public virtual string GetDetails()
        {
            return $"{Make} {Model} ({Year}) - Registration: {RegistrationNumber}, Rent Price: {RentalPricePerDay} per day";
        }
        public void Rent()
        {
            Available = false;
        }
        public void Return()
        {
            Available = true;
        }
    }
}
