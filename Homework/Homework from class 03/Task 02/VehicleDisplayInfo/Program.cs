namespace VehicleDisplayInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Vehicle subclasses
            Vehicle car = new Car();
            Vehicle motorBike = new MotorBike();
            Vehicle boat = new Boat();
            Vehicle plane = new Airplane();

            // Display information for each vehicle
            car.DisplayInfo();
            motorBike.DisplayInfo();
            boat.DisplayInfo();
            plane.DisplayInfo();
        }
    }
}
