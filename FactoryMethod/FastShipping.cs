namespace FactoryMethod
{
    public class FastShipping : DeliveryMethod
    {
        public override IVehicle VehicleFactory()
        {
            return new AirCraft();
        }
    }
}