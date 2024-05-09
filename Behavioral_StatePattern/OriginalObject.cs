namespace Behavioral_StatePattern
{
    public class OriginalObject
    {
        private IState _state;
        private int temperature;

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public OriginalObject()
        {
            _state = new RareSteakState();
            temperature = 0;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Cook()
        {
            temperature += 10;
            Console.WriteLine("Temperature increased by 10. Current temperature is " + temperature);
            _state.Cook(this);
        }
    }
}