using BuilderPattern.Builder;
using BuilderPattern.Director;

var director = new HourseDirector();
var nomalHouseBuilder = new NomalHouseBuilder();
var nomalHouse = director.BuilderHouse(nomalHouseBuilder);
Console.WriteLine(nomalHouse);
Console.WriteLine("=====================================");

var fancyHouseBuilder = new FancyHouseBuilder();
var fancyHouse = director.BuilderHouse(fancyHouseBuilder);
Console.WriteLine(fancyHouse);