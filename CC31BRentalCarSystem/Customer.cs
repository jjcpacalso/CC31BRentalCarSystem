using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31BRentalCarSystem
{
    public class Customer
    {
        private static int s_CustomerIDSeed = 9;
        public string Name { get; set; }
        public int PhoneNumber {  get; set; }
        public int CustomerId {  get; }

        public Customer(string name, int phoneNumber)
        {
            CustomerId = s_CustomerIDSeed++;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void RentVehicle(Vehicle vehicle)
        {
            vehicle.Rent();
            Console.WriteLine($"Car rented: {vehicle.GetDetails()}");
        }

        public void ReturnVehicle(Vehicle vehicle)
        {
            vehicle.Return();
            Console.WriteLine($"Car returned: {vehicle.GetDetails()}");
        }
    }
}
