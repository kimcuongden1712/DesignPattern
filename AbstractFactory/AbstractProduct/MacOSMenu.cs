namespace AbstractFactory.AbstractProduct
{
    public class MacOSMenu : IMenu
    {
        public void Select()
        {
            Console.WriteLine("MacOS Menu Selected");
        }
    }
}