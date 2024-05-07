namespace BuilderPattern.Builder
{
    public class FancyHouseBuilder : HouseBuilder
    {
        protected override House houseObject { get; set; }

        public override void BuildBasement()
        {
            houseObject.Basement = "Fancy Basement";
        }

        public override void BuildInterior()
        {
            houseObject.Interior = "Fancy Interior";
        }

        public override void BuildRoof()
        {
            houseObject.Roof = "Fancy Roof";
        }

        public override void BuildStructure()
        {
            houseObject.Structure = "Fancy Structure";
        }
    }
}