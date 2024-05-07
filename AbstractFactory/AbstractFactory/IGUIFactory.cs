using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public interface IGUIFactory
    {
        IButton CreateButton();

        ITextbox CreateTextbox();

        IMenu CreateMenu();
    }
}