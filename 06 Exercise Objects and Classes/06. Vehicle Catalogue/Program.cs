using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> truck = new List<Vehicle>();

            GenerationVehicles(vehicles, cars, truck);
            PrintModelData(vehicles);
            PrintCarAverageHorsepower(vehicles, cars);
            PrintTruckAverageHorsepower(vehicles, truck);
        }
        static void GenerationVehicles(List<Vehicle> vehicles, List<Vehicle> cars, List<Vehicle> truck)
        {
            string text;

            while ((text = Console.ReadLine()) != "End")
            {
                string[] vehicleData = text
                    .Split();

                string type = vehicleData[0];
                string model = vehicleData[1];
                string color = vehicleData[2];
                double horsepower = int.Parse(vehicleData[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);

                if (vehicle.Type == "car")
                {
                    cars.Add(vehicle);
                }

                else
                {
                    truck.Add(vehicle);
                }

                vehicles.Add(vehicle);
            }
        }
        static void PrintModelData(List<Vehicle> vehicles)
        {
            string text;

            while ((text = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = text;

                for (int i = 0; i < vehicles.Count; i++)
                {
                    Vehicle currentVehicle = vehicles[i];

                    if (model == currentVehicle.Model || model == currentVehicle.Color || model == currentVehicle.Horsepower.ToString())
                    {
                        if (currentVehicle.Type == "car")
                        {
                            Console.WriteLine("Type: Car");
                        }

                        else
                        {
                            Console.WriteLine("Type: Truck");
                        }

                        Console.WriteLine($"Model: {currentVehicle.Model}");
                        Console.WriteLine($"Color: {currentVehicle.Color}");
                        Console.WriteLine($"Horsepower: {currentVehicle.Horsepower}");
                        break;
                    }
                }
            }
        }
        static void PrintCarAverageHorsepower(List<Vehicle> vehicles, List<Vehicle> cars)
        {
            int carsCount = cars.Count;
            double carsSumOfHorsepower = 0;
            //Тук създаваме стойността на средните конски сили
            double averageCarsSumOfHorsepower = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                carsSumOfHorsepower += cars[i].Horsepower;
            }
            //Тук добавяме една иф проверка, с която предпазваме от делене на 0
            if (carsCount > 0)
            {
                averageCarsSumOfHorsepower = carsSumOfHorsepower / carsCount;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarsSumOfHorsepower:F2}.");
        }

        static void PrintTruckAverageHorsepower(List<Vehicle> vehicles, List<Vehicle> truck)
        {
            int truckCount = truck.Count;
            double truckSumOfHorsepower = 0;
            //Тук създаваме стойността на средните конски сили
            double averageTruckSumOfHorsepower = 0;
            for (int i = 0; i < truck.Count; i++)
            {
                truckSumOfHorsepower += truck[i].Horsepower;
            }
            //Тук добавяме една иф проверка, с която предпазваме от делене на 0
            if (truckCount > 0)
            {
                averageTruckSumOfHorsepower = truckSumOfHorsepower / truckCount;
            }
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckSumOfHorsepower:F2}.");
        }

    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }
}