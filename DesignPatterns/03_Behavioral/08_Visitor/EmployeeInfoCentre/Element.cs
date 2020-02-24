namespace DesignPatterns._03_Behavioral._08_Visitor.EmployeeInfoCentre
{
    // Element abstract class
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}