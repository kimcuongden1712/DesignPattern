using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public class MacOSGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public IMenu CreateMenu()
        {
            return new MacOSMenu();
        }

        public ITextbox CreateTextbox()
        {
            return new MacOSTextbox();
        }
    }
}