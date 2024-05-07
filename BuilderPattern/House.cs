namespace BuilderPattern
{
    public class House
    {
        public string Basement { get; set; }
        public string Structure { get; set; }
        public string Roof { get; set; }
        public string Interior { get; set; }

        public override string ToString()
        {
            return $"House with {Basement}, {Structure}, {Roof}, {Interior}";
        }
    }
}