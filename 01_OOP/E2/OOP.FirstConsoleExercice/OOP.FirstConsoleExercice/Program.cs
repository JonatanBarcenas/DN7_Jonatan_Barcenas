using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.FirstConsoleExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador<=10)
            {
                Console.WriteLine("Type the vehicle");
                string vehicleType = Console.ReadLine().ToLower();
                


                Vehicle vehicle=null;
                switch (vehicleType)
                {
                    case "car":
                        vehicle= new Car();
                        break;

                    case "truck":
                        vehicle = new Truck();
                        break;

                    case "train":
                       vehicle= new Train();
                        break;

                    default:
                        Console.WriteLine("Vehicle not found");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }

                if (vehicle != null)
                {
                    vehicle.VehicleSound();
                    contador++;

                }
            }
        }
    }
}
