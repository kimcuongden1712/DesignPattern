using Behavioral_VisitorPattern;

var emp = new List<IElement>
{
    new BOEmployee { Name = "Bob", Income = 20000, Bonus = 5000 },
    new BOEmployee { Name = "Alice", Income = 30000, Bonus = 10000 },
    new SaleEmployee { Name = "Sara", Income = 25000, Commission = 1000 },
    new SaleEmployee { Name = "Sara1", Income = 235000, Commission = 1000 }
};

var concereteVisitor = new ConcreteVisitor();

emp.ForEach(e => e.Accept(concereteVisitor));
Console.WriteLine($"Total Income: {concereteVisitor.TotalIncome:C}");

Console.WriteLine();

var esoVisitor = new ConcreteStockOptionVisitor();
emp.ForEach(e => e.Accept(esoVisitor));

Console.WriteLine("Total unit: {0}", esoVisitor.TotalUnit);