namespace Behavioral_TemplatePattern
{
    public class ConcreteWoodenHouse : AbstractClass
    {
        protected override void BuildRoof()
        {
            Console.WriteLine("Building roof with wood, composite shingles");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building wooden walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Building wooden windows");
        }

        protected override void BuildFoundation()
        {
            // Wooden houses have wooden foundations
            //Check foundation is built
            Console.WriteLine("Building foundation with wood");
            base.BuildFoundation();
        }
    }
}