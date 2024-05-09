namespace Behavioral_VisitorPattern
{
    public interface IVisitor
    {
        void Visit(SaleEmployee sale);

        void Visit(BOEmployee bo);
    }
}