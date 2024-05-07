namespace FactoryMethod
{
    public class Client
    {
        public void Deliver(DeliveryMethod deliveryMethod)
        {
            System.Console.WriteLine(deliveryMethod.Delivery());
        }
    }
}