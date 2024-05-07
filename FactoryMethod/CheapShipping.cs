namespace FactoryMethod
{
    public class CheapShipping : DeliveryMethod
    {
        public override IVehicle VehicleFactory()
        {
            return new Ship();
        }
    }
}