namespace DesignPatterns._03_Behavioral._08_Visitor.Animals
{
    public class Speak : IAnimalOperation
    {
        public void VisitMonkey(Monkey monkey)
        {
            monkey.Shout();
        }

        public void VisitLion(Lion lion)
        {
            lion.Roar();
        }

        public void VisitWolf(Wolf wolf)
        {
            wolf.Grrr();
        }
    }
}