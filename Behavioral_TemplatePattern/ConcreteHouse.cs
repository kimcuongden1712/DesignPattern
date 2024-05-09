namespace Behavioral_TemplatePattern
{
    public class ConcreteHouse : AbstractClass
    {
        protected override void BuildRoof()
        {
            Console.WriteLine("Building roof with concrete, iron sheets");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building concrete walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Building glass windows");
        }
    }
}