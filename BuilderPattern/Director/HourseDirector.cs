using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class HourseDirector
    {
        public House BuilderHouse(HouseBuilder builder)
        {
            builder.CreateNewHouse();
            builder.BuildBasement();
            builder.BuildStructure();
            builder.BuildRoof();
            builder.BuildInterior();
            return builder.GetHouse();
        }
    }
}