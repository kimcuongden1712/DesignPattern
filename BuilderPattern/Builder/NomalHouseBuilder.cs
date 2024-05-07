namespace BuilderPattern.Builder
{
    public class NomalHouseBuilder : HouseBuilder
    {
        protected override House houseObject { get; set; }

        public override void BuildBasement()
        {
            houseObject.Basement = "Nomal Basement";
        }

        public override void BuildInterior()
        {
            houseObject.Interior = "Nomal Interior";
        }

        public override void BuildRoof()
        {
            houseObject.Roof = "Nomal Roof";
        }

        public override void BuildStructure()
        {
            houseObject.Structure = "Nomal Structure";
        }
    }
}