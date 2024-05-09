namespace Behavioral_StatePattern
{
    public class MediumSteakState : IState
    {
        public void Cook(OriginalObject originalObject)
        {
            if (originalObject.Temperature < 140)
            {
                System.Console.WriteLine("Medium steak is being cooked.");
            }
            else
            {
                originalObject.SetState(new WellDoneSteakState());
                originalObject.Cook();
            }
        }
    }
}