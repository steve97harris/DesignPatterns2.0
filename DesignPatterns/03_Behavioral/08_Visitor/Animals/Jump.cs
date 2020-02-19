using System;

namespace DesignPatterns._03_Behavioral._08_Visitor.Animals
{
    public class Jump : IAnimalOperation
    {
        public void VisitMonkey(Monkey monkey)
        {
            Console.WriteLine("Monkey swinging on branches");
        }

        public void VisitLion(Lion lion)
        {
            Console.WriteLine("Lion goes to sleep");
        }

        public void VisitWolf(Wolf wolf)
        {
            Console.WriteLine("Wolf eats meat");
        }
    }
}