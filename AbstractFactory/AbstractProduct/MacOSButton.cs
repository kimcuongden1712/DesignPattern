namespace AbstractFactory.AbstractProduct
{
    public class MacOSButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacOS Button Clicked");
        }
    }
}