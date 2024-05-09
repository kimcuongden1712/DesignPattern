namespace Behavioral_TemplatePattern
{
    public abstract class AbstractClass
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            BuildRoof();
            Console.WriteLine("House is built.");
        }

        protected abstract void BuildRoof();

        protected abstract void BuildWindows();

        protected abstract void BuildWalls();

        protected virtual void BuildPillars()
        {
            Console.WriteLine("Building Pillars with concrete");
        }

        protected virtual void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods and sand");
        }
    }
}