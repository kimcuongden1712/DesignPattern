using AbstractFactory.AbstractFactory;

namespace AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            GeneralUI(new WindowsOSGUIFactory());
            Console.WriteLine("===========");
            GeneralUI(new MacOSGUIFactory());
        }

        private void GeneralUI(IGUIFactory factory)
        {
            var textBox = factory.CreateTextbox();
            var button = factory.CreateButton();
            var menu = factory.CreateMenu();

            textBox.Input();
            button.Click();
            menu.Select();
        }
    }
}