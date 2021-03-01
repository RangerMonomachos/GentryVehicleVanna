using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace GentryVehicleVanna
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,[Queue("vehicle")] IAsyncCollector<Vehicle> vehicleQueue,
            ILogger log)
        {
            log.LogInformation("Vehical request sent.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var vehicle = JsonConvert.DeserializeObject<Vehicle>(requestBody);
            await vehicleQueue.AddAsync(vehicle);
            double FinalPrice = (vehicle.ListPrice * 0.915);
            Math.Round(FinalPrice, 2);

            log.LogInformation($"{vehicle.BuyerLast}, {vehicle.BuyerFirst} got a {vehicle.year} {vehicle.Make} {vehicle.Model} with a list price of ${vehicle.ListPrice}. This is a {vehicle.vehicleType} with a final price of ${FinalPrice}. Buyer Email is {vehicle.Email}");

            string responseMessage = ($"Buyer {vehicle.BuyerFirst} {vehicle.BuyerLast} ({vehicle.Email}) purchased a {vehicle.year} {vehicle.Make} {vehicle.Model} {vehicle.vehicleType} with a list price of ${vehicle.ListPrice}. with discount applied, purchase price is ${FinalPrice}.");

            return new OkObjectResult(responseMessage);
        }
    }
}
