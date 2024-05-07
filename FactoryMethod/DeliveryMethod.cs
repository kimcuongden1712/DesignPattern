namespace FactoryMethod
{
    public abstract class DeliveryMethod
    {
        public abstract IVehicle VehicleFactory();

        public string Delivery()
        {
            var vehicle = VehicleFactory();
            var result = $"Delivery is done by {vehicle.Openration()}";
            return result;
        }
    }
}