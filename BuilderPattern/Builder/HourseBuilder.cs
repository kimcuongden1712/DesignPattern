namespace BuilderPattern.Builder
{
    public abstract class HouseBuilder
    {
        protected abstract House houseObject { get; set; }

        public abstract void BuildBasement();

        public abstract void BuildStructure();

        public abstract void BuildRoof();

        public abstract void BuildInterior();

        public void CreateNewHouse()
        {
            houseObject = new House();
        }

        public House GetHouse()
        {
            return houseObject;
        }
    }
}