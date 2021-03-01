using System;
using System.Collections.Generic;
using System.Text;

namespace GentryVehicleVanna
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int year { get; set; }
        public double ListPrice { get; set; }
        public string BuyerFirst { get; set; }
        public string BuyerLast { get; set; }
        public string Email { get; set; }
        public VehicleType vehicleType { get; set; }

    }
    public enum VehicleType
    {
        Car,
        SportsCar,
        Truck,
        Motorcycle,
        MotorHome
    }

}
