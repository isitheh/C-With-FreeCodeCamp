using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Vehicle
    {
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public int Mileage { get; set; } = 0;

        public Vehicle(string make, string model, int mileage)
        {
            this.Make = make;
            this.Model = model;
            this.Mileage = mileage;
        }

        public static string ReturnDetails(Vehicle vehicle)
        {
            return $"Make: {vehicle.Make}, model: {vehicle.Model}, mileage: {vehicle.Mileage}";
        }

        public string ReturnDetails()
        {
            return $"Make: {Make}, model: {Model}, mileage: {Mileage}";
        }

        public override string ToString()
        {
            return $"Make: {Make}, model: {Model}, mileage: {Mileage}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Vehicle)
            {
                Vehicle vehicle = (Vehicle) obj;
                return Make == vehicle.Make && Model == vehicle.Model && Mileage == vehicle.Mileage;
            }
            return false;

        }
    }
}
