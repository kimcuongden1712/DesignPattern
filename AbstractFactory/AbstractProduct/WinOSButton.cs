namespace AbstractFactory.AbstractProduct
{
    public class WinOSButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("WinOS Button Clicked");
        }
    }
}