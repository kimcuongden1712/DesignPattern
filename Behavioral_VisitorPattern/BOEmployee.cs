namespace Behavioral_VisitorPattern
{
    public class BOEmployee : Employee, IElement
    {
        public double Bonus { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}