namespace AbstractFactory.AbstractProduct
{
    public class WinOSMenu : IMenu
    {
        public void Select()
        {
            Console.WriteLine("WinOS Menu Selected");
        }
    }
}