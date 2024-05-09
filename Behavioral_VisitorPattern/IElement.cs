namespace Behavioral_VisitorPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}