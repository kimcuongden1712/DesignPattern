using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public class WindowsOSGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinOSButton();
        }

        public IMenu CreateMenu()
        {
            return new WinOSMenu();
        }

        public ITextbox CreateTextbox()
        {
            return new WinOSTextbox();
        }
    }
}