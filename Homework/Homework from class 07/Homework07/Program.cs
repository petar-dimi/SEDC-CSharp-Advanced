namespace Homework07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Filter all cars that have origin from Europe and print them in the console.
            var europeanCars = CarsData.Cars.Where(car => car.Origin == "Europe").ToList();
            Console.WriteLine("European Cars:");
            foreach (var car in europeanCars)
            {
                Console.WriteLine(car.Model);
            }

            // 2. Filter all cars that have more than 6 Cylinders not including 6, 
            // then filter all cars that have exactly 4 Cylinders and HorsePower more than 110.0.
            var filteredCars = CarsData.Cars
                .Where(car => car.Cylinders > 6)
                .Concat(CarsData.Cars
                    .Where(car => car.Cylinders == 4 && car.HorsePower > 110.0))
                .ToList();

            Console.WriteLine("\nFiltered Cars (More than 6 Cylinders or 4 Cylinders with HorsePower > 110):");
            foreach (var car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }

            // 3. Count all cars based on their Origin and print the result.
            var carsByOrigin = CarsData.Cars
                .GroupBy(car => car.Origin)
                .Select(g => $"{g.Key} {g.Count()} models")
                .ToList();

            Console.WriteLine("\nCount of cars by origin:");
            foreach (var originCount in carsByOrigin)
            {
                Console.WriteLine(originCount);
            }

            // 4. Filter all cars that have more than 200 HorsePower and find the lowest,
            // highest, and average Miles per gallon.
            var powerfulCars = CarsData.Cars.Where(car => car.HorsePower > 200).ToList();
            if (powerfulCars.Any())
            {
                var minMpg = powerfulCars.Min(car => car.MilesPerGalon);
                var maxMpg = powerfulCars.Max(car => car.MilesPerGalon);
                var avgMpg = powerfulCars.Average(car => car.MilesPerGalon);

                Console.WriteLine($"\nPowerful Cars (HorsePower > 200):");
                Console.WriteLine($"Lowest MPG: {minMpg}");
                Console.WriteLine($"Highest MPG: {maxMpg}");
                Console.WriteLine($"Average MPG: {avgMpg}");
            }
            else
            {
                Console.WriteLine("\nNo cars found with HorsePower greater than 200.");
            }

            // 5. Find the top 3 fastest-accelerating cars
            var top3FastestCars = CarsData.Cars
                .OrderBy(car => car.AccelerationTime)
                .Take(3)
                .ToList();

            Console.WriteLine("\nTop 3 Fastest Accelerating Cars:");
            foreach (var car in top3FastestCars)
            {
                Console.WriteLine(car.Model);
            }

            // 6. Calculate the total weight of cars with more than 6 cylinders.
            var totalWeight = CarsData.Cars
                .Where(car => car.Cylinders > 6)
                .Sum(car => car.Weight);

            Console.WriteLine($"\nTotal weight of cars with more than 6 cylinders: {totalWeight}");

            // 7. Find the average MilesPerGalon for cars with an even number of cylinders.
            var evenCylinderCars = CarsData.Cars
                .Where(car => car.Cylinders % 2 == 0)
                .ToList();

            if (evenCylinderCars.Any())
            {
                var avgMpgEvenCylinders = evenCylinderCars.Average(car => car.MilesPerGalon);
                Console.WriteLine($"Average MPG for cars with an even number of cylinders: {avgMpgEvenCylinders}");
            }
            else
            {
                Console.WriteLine("\nNo cars found with an even number of cylinders.");
            }
        }
    }
}
