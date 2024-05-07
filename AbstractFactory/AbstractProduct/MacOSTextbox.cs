namespace AbstractFactory.AbstractProduct
{
    public class MacOSTextbox : ITextbox
    {
        public void Input()
        {
            Console.WriteLine("MacOS Textbox Input");
        }
    }
}