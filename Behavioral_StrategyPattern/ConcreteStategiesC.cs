namespace Behavioral_StrategyPattern
{
    public class ConcreteStategiesC : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStategiesC.Execute()");
        }
    }
}