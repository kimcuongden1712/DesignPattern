namespace Behavioral_VisitorPattern
{
    public class ConcreteVisitor : IVisitor
    {
        private double _totalIncome = 0;
        public double TotalIncome => _totalIncome;

        public void Visit(SaleEmployee e)
        {
            _totalIncome += e.Income + e.Commission;
            Console.WriteLine($"TotalIncome Sale: {TotalIncome}");
        }

        public void Visit(BOEmployee e)
        {
            _totalIncome += e.Income + e.Bonus;
            Console.WriteLine($"TotalIncome back office: {TotalIncome}");
        }
    }
}