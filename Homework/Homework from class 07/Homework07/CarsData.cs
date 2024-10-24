using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07
{
    public static class CarsData
    {
        public static List<Car> Cars = new List<Car>();
        static CarsData()
        {
            LoadCars();
        }

        public static void LoadCars()
        {
            Cars = new List<Car>()
        {
            new Car() { Model = "Chevrolet Chevelle Malibu", MilesPerGalon = 18, AccelerationTime = 12, Cylinders = 8, HorsePower = 130, Origin = "US", Weight = 3504 },
new Car() { Model = "Plymouth Satellite", MilesPerGalon = 18, AccelerationTime = 11, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3436 },
new Car() { Model = "AMC Rebel SST", MilesPerGalon = 16, AccelerationTime = 12, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3433 },
new Car() { Model = "Ford Galaxie 500", MilesPerGalon = 15, AccelerationTime = 10, Cylinders = 8, HorsePower = 198, Origin = "US", Weight = 4341 },
new Car() { Model = "Chevrolet Impala", MilesPerGalon = 14, AccelerationTime = 9, Cylinders = 8, HorsePower = 220, Origin = "US", Weight = 4354 },
new Car() { Model = "Dodge Challenger SE", MilesPerGalon = 15, AccelerationTime = 10, Cylinders = 8, HorsePower = 170, Origin = "US", Weight = 3563 },
new Car() { Model = "Plymouth 'Cuda 340", MilesPerGalon = 14, AccelerationTime = 8, Cylinders = 8, HorsePower = 160, Origin = "US", Weight = 3609 },
new Car() { Model = "Ford Mustang Boss 302", MilesPerGalon = 0, AccelerationTime = 8, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 3353 },
new Car() { Model = "Buick Estate Wagon (sw)", MilesPerGalon = 14, AccelerationTime = 10, Cylinders = 8, HorsePower = 225, Origin = "US", Weight = 3086 },
new Car() { Model = "Toyota Corolla", MilesPerGalon = 25, AccelerationTime = 14, Cylinders = 4, HorsePower = 95, Origin = "Japan", Weight = 2228 },
new Car() { Model = "Ford F250", MilesPerGalon = 10, AccelerationTime = 14, Cylinders = 8, HorsePower = 215, Origin = "US", Weight = 4615 },
new Car() { Model = "Volkswagen Super Beetle 117", MilesPerGalon = 0, AccelerationTime = 20, Cylinders = 4, HorsePower = 48, Origin = "Europe", Weight = 1978 },
new Car() { Model = "AMC Gremlin", MilesPerGalon = 19, AccelerationTime = 13, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 2634 },
new Car() { Model = "Chevrolet Impala", MilesPerGalon = 14, AccelerationTime = 12, Cylinders = 8, HorsePower = 165, Origin = "US", Weight = 4209 },
new Car() { Model = "Plymouth Fury iii", MilesPerGalon = 14, AccelerationTime = 13, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4096 },
new Car() { Model = "Ford Country Squire (sw)", MilesPerGalon = 13, AccelerationTime = 12, Cylinders = 8, HorsePower = 170, Origin = "US", Weight = 4746 },
new Car() { Model = "Pontiac Firebird", MilesPerGalon = 19, AccelerationTime = 15, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3282 },
new Car() { Model = "Mercury Capri 2000", MilesPerGalon = 23, AccelerationTime = 14, Cylinders = 4, HorsePower = 86, Origin = "US", Weight = 2220 },
new Car() { Model = "Toyota Corolla 1200", MilesPerGalon = 31, AccelerationTime = 19, Cylinders = 4, HorsePower = 65, Origin = "Japan", Weight = 1773 },
new Car() { Model = "Datsun 1200", MilesPerGalon = 35, AccelerationTime = 18, Cylinders = 4, HorsePower = 69, Origin = "Japan", Weight = 1613 },
new Car() { Model = "Chevrolet Impala", MilesPerGalon = 13, AccelerationTime = 12, Cylinders = 8, HorsePower = 165, Origin = "US", Weight = 4274 },
new Car() { Model = "Pontiac Catalina", MilesPerGalon = 14, AccelerationTime = 12, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 4385 },
new Car() { Model = "Mercury Marquis", MilesPerGalon = 11, AccelerationTime = 11, Cylinders = 8, HorsePower = 208, Origin = "US", Weight = 4633 },
new Car() { Model = "Chevrolet Chevelle Concours (sw)", MilesPerGalon = 13, AccelerationTime = 14, Cylinders = 8, HorsePower = 130, Origin = "US", Weight = 4098 },
new Car() { Model = "Ford Gran Torino (sw)", MilesPerGalon = 13, AccelerationTime = 16, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 4294 },
new Car() { Model = "Plymouth Satellite Custom (sw)", MilesPerGalon = 14, AccelerationTime = 14, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4077 },
new Car() { Model = "Volkswagen 411 (sw)", MilesPerGalon = 22, AccelerationTime = 18, Cylinders = 4, HorsePower = 76, Origin = "Europe", Weight = 2511 },
new Car() { Model = "Dodge Colt (sw)", MilesPerGalon = 28, AccelerationTime = 15, Cylinders = 4, HorsePower = 80, Origin = "US", Weight = 2164 },
new Car() { Model = "Ford Pinto (sw)", MilesPerGalon = 22, AccelerationTime = 16, Cylinders = 4, HorsePower = 86, Origin = "US", Weight = 2395 },
new Car() { Model = "Datsun 510 (sw)", MilesPerGalon = 28, AccelerationTime = 17, Cylinders = 4, HorsePower = 92, Origin = "Japan", Weight = 2288 },
new Car() { Model = "Buick Century 350", MilesPerGalon = 13, AccelerationTime = 13, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 4100 },
new Car() { Model = "Chevrolet Malibu", MilesPerGalon = 13, AccelerationTime = 13, Cylinders = 8, HorsePower = 145, Origin = "US", Weight = 3988 },
new Car() { Model = "Mercury Marquis Brougham", MilesPerGalon = 12, AccelerationTime = 11, Cylinders = 8, HorsePower = 198, Origin = "US", Weight = 4952 },
new Car() { Model = "Chevrolet Caprice Classic", MilesPerGalon = 13, AccelerationTime = 12, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4464 },
new Car() { Model = "Ford LTD", MilesPerGalon = 13, AccelerationTime = 13, Cylinders = 8, HorsePower = 158, Origin = "US", Weight = 4363 },
new Car() { Model = "Chrysler New Yorker Brougham", MilesPerGalon = 13, AccelerationTime = 11, Cylinders = 8, HorsePower = 215, Origin = "US", Weight = 4735 },
new Car() { Model = "Buick Electra 225 Custom", MilesPerGalon = 12, AccelerationTime = 11, Cylinders = 8, HorsePower = 225, Origin = "US", Weight = 4951 },
new Car() { Model = "AMC Ambassador Brougham", MilesPerGalon = 13, AccelerationTime = 11, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 3821 },
new Car() { Model = "AMC Gremlin", MilesPerGalon = 18, AccelerationTime = 15, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 2789 },
new Car() { Model = "Chevrolet Nova Custom", MilesPerGalon = 16, AccelerationTime = 18, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3278 },
new Car() { Model = "AMC Hornet", MilesPerGalon = 18, AccelerationTime = 16, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 2945 },
new Car() { Model = "Plymouth Duster", MilesPerGalon = 23, AccelerationTime = 16, Cylinders = 6, HorsePower = 95, Origin = "US", Weight = 2904 },
new Car() { Model = "Chevrolet Vega", MilesPerGalon = 21, AccelerationTime = 19, Cylinders = 4, HorsePower = 72, Origin = "US", Weight = 2401 },
new Car() { Model = "Plymouth Grand Fury", MilesPerGalon = 16, AccelerationTime = 14, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4498 },
new Car() { Model = "Ford Pinto", MilesPerGalon = 18, AccelerationTime = 14, Cylinders = 6, HorsePower = 97, Origin = "US", Weight = 2984 },
new Car() { Model = "AMC Gremlin", MilesPerGalon = 20, AccelerationTime = 16, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 2914 },
new Car() { Model = "Audi 100LS", MilesPerGalon = 23, AccelerationTime = 15, Cylinders = 4, HorsePower = 95, Origin = "Europe", Weight = 2694 },
new Car() { Model = "Ford Pinto", MilesPerGalon = 23, AccelerationTime = 17, Cylinders = 4, HorsePower = 83, Origin = "US", Weight = 2639 },
new Car() { Model = "AMC Pacer", MilesPerGalon = 19, AccelerationTime = 17, Cylinders = 6, HorsePower = 90, Origin = "US", Weight = 3211 },
new Car() { Model = "Volkswagen Rabbit", MilesPerGalon = 29, AccelerationTime = 14, Cylinders = 4, HorsePower = 70, Origin = "Europe", Weight = 1937 },
new Car() { Model = "Peugeot 504", MilesPerGalon = 23, AccelerationTime = 17, Cylinders = 4, HorsePower = 88, Origin = "Europe", Weight = 2957 },
new Car() { Model = "Mercury Capri v6", MilesPerGalon = 21, AccelerationTime = 14, Cylinders = 6, HorsePower = 107, Origin = "US", Weight = 2472 },
new Car() { Model = "Audi 100LS", MilesPerGalon = 20, AccelerationTime = 14, Cylinders = 4, HorsePower = 91, Origin = "Europe", Weight = 2582 },
new Car() { Model = "Ford Gran Torino", MilesPerGalon = 16, AccelerationTime = 14, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 4141 },
new Car() { Model = "Ford LTD", MilesPerGalon = 14, AccelerationTime = 13, Cylinders = 8, HorsePower = 148, Origin = "US", Weight = 4657 },
new Car() { Model = "Pontiac Catalina", MilesPerGalon = 16, AccelerationTime = 11, Cylinders = 8, HorsePower = 170, Origin = "US", Weight = 4668 },
new Car() { Model = "Ford Pinto", MilesPerGalon = 23, AccelerationTime = 17, Cylinders = 4, HorsePower = 83, Origin = "US", Weight = 2639 },
        };
        }
    }
}
