namespace Behavioral_StrategyPattern
{
    public class ConcreteStategiesA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStategiesA.Execute()");
        }
    }
}