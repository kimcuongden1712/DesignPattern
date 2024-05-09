namespace Behavioral_VisitorPattern
{
    public class ConcreteStockOptionVisitor : IVisitor
    {
        private double _totalUnit = 0;
        public double TotalUnit => _totalUnit;

        public void Visit(SaleEmployee e)
        {
            var totalIncome = e.Commission * 0.1 + e.Income;
            Console.WriteLine("Total Income inclue Stock options for sale employee are {0}", totalIncome);
        }

        public void Visit(BOEmployee e)
        {
            var totalIncome = e.Bonus * 0.5 + e.Income;
            Console.WriteLine("Total Income inclue Stock options for sale employee are {0}", totalIncome);
        }
    }
}