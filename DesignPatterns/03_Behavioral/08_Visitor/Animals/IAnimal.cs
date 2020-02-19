namespace DesignPatterns._03_Behavioral._08_Visitor.Animals
{
    public interface IAnimal
    {
        void Accept(IAnimalOperation operation);
    }

    public interface IAnimalOperation
    {
        void VisitMonkey(Monkey monkey);
        void VisitLion(Lion lion);
        void VisitWolf(Wolf wolf);
    }
}