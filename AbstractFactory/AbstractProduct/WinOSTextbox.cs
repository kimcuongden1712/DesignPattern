namespace AbstractFactory.AbstractProduct
{
    public class WinOSTextbox : ITextbox
    {
        public void Input()
        {
            Console.WriteLine("Windows Textbox Input");
        }
    }
}