using Behavioral_StrategyPattern;

IStrategy carRouter = new ConcreteStategiesA();
IStrategy bikeRouter = new ConcreteStategiesB();
IStrategy motoRouter = new ConcreteStategiesC();

Context context = new Context(carRouter);
context.ExecuteStrategy();
context.SetStrategy(bikeRouter);
context.ExecuteStrategy();
context.SetStrategy(motoRouter);
context.ExecuteStrategy();