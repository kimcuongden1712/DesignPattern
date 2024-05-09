namespace Behavioral_VisitorPattern
{
    public class SaleEmployee : Employee, IElement
    {
        public double Commission { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}