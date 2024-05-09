using Behavioral_TemplatePattern;

AbstractClass houseTemplate = new ConcreteHouse();
houseTemplate.BuildHouse();
Console.WriteLine();
houseTemplate = new ConcreteWoodenHouse();
houseTemplate.BuildHouse();