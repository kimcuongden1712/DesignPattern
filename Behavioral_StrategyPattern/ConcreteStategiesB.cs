namespace Behavioral_StrategyPattern
{
    internal class ConcreteStategiesB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStategiesB.Execute()");
        }
    }
}