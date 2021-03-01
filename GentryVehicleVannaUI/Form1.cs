using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using GentryVehicleVanna;

namespace GentryVehicleVannaUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async void RunTheThing_Click(object sender, EventArgs e)
        {
            VehicleType vt = VTConverter(VehicleTypeAnswer.Text);
            Vehicle newVehicle = new Vehicle("Ranger", "Monomachos", "james.edwin.gentry@gmail.com", "Tesla", "S", 2021, 25000.00, vt);

            string azurefuntion = "http://localhost:7071/api/Function1";
            var client = new HttpClient();
            HttpResponseMessage outputString = await client.PostAsJsonAsync(azurefuntion, newVehicle);
            MessageBox.Show(outputString.Content.ReadAsStringAsync().Result.ToString());
        }
        public VehicleType VTConverter(string choice)
        {
            switch (choice)
            {
                case "Car":
                    return VehicleType.Car;

                case "Sports Car":
                    return VehicleType.SportsCar;

                case "Truck":
                    return VehicleType.Truck;

                case "Motoercycle":
                    return VehicleType.Motorcycle;

                case "MotorHome":
                    return VehicleType.MotorHome;

                default:
                    return VehicleType.SportsCar;

            }
        }
    }
    public class Vehicle
    {
        public Vehicle(string first, string last, string email, string make, string model, int year, double listPrice, VehicleType vehicletype)
        {
            BuyerFirst = first;
            BuyerLast = last;
            Email = email;
            Make = make;
            Model = model;
            Year = year;
            ListPrice = listPrice;
            vehicleType = vehicletype;
        }
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public double ListPrice { get; }
        public string BuyerFirst { get; }
        public string BuyerLast { get; }
        public string Email { get; }
        public VehicleType vehicleType { get; }

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
