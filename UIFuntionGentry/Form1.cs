using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;

namespace UIFuntionGentry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void RunTheThing_Click(object sender, EventArgs e)
        {
            VehicleType vt = VTConverter(VehicalTypeAnswer.Text);
            if(MakeAnswer.Text != "" && ModelAnswer.Text != "" && YearAnswer.Text != "" && PriceAnswer.Text != "" && FirstNameAnswer.Text != "" && LastNameAnswer.Text != "" && EmailAnswer.Text != "")
            {
                int VehicalYear = int.Parse(YearAnswer.Text);
                double PrictEntered = double.Parse(PriceAnswer.Text);
                Vehicle newVehicle = new Vehicle(FirstNameAnswer.Text, LastNameAnswer.Text, EmailAnswer.Text, MakeAnswer.Text, ModelAnswer.Text, VehicalYear, PrictEntered, vt);

                string azurefuntion = "https://gentryvehiclevanna.azurewebsites.net/api/Function1?code=jR7HtZ3sy0vcC8IVNPDQXbENI/KhVHB5xWTw/5/jmZhaw4V3u8MmDg==";
                var client = new HttpClient();
                HttpResponseMessage outputString = await client.PostAsJsonAsync(azurefuntion, newVehicle);
                MessageBox.Show(outputString.Content.ReadAsStringAsync().Result.ToString());
            }
            else 
            {
                MessageBox.Show("Not all requierd fields are filled in. Please fill in all requiered fields");
            }
   
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