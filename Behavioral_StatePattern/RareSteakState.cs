namespace Behavioral_StatePattern
{
    public class RareSteakState : IState
    {
        public void Cook(OriginalObject originalObject)
        {
            if (originalObject.Temperature < 120)
            {
                System.Console.WriteLine("Rare steak is being cooked.");
            }
            else
            {
                originalObject.SetState(new MediumSteakState());
                originalObject.Cook();
            }
        }
    }
}