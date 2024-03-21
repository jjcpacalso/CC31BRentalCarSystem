namespace CC31BRentalCarSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car yourCar = new Car ("ABC123", "Toyota", "Innova", 2017, 3500, true, 5);
            Car theirCar = new Car("DEF456", "Mitsubishi", "Mirage", 2021, 2000, true, 5);
            Truck truckKun = new Truck("GHI231", "Hino", "Kahit Ano", 2024, 5000, true, 5);
            Truck truckSan = new Truck("DIS741", "Isuzu", "ModelNya", 2017, 7000, true, 10);

            Customer jaiden = new Customer("Jaiden", 0909123);
            Customer jack = new Customer("Jack", 56789);

            RentalSystem rs = new RentalSystem();
            rs.AddVehicle( yourCar );
            rs.AddVehicle( theirCar );
            rs.AddVehicle(truckSan);
            rs.AddVehicle(truckKun);

            rs.DisplayAvailableVehicles();

            rs.RentVehicle(yourCar, jaiden);

            rs.DisplayRentedVehicles();
        }
    }
}
