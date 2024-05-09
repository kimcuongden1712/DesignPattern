namespace Behavioral_StatePattern
{
    public class WellDoneSteakState : IState
    {
        public void Cook(OriginalObject originalObject)
        {
            if (originalObject.Temperature < 160)
            {
                System.Console.WriteLine("Well done steak is being cooked.");
            }
            else
            {
                System.Console.WriteLine("Steak is ready.");
            }
        }
    }
}