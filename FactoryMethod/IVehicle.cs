namespace FactoryMethod
{
    // Step 1: Create an interface/abstract class
    public interface IVehicle
    {
        string Openration();
    }

    // Step 2: Create concrete classes implementing the same interface/abstract class
    public class Ship : IVehicle
    {
        public string Openration()
        {
            return "Ship is created.";
        }
    }

    public class AirCraft : IVehicle
    {
        public string Openration()
        {
            return "AirCraft is created.";
        }
    }

    public class Car : IVehicle
    {
        public string Openration()
        {
            return "Car is created.";
        }
    }
}