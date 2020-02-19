using System;
using DesignPatterns._basicconcepts;

namespace DesignPatterns._03_Behavioral._08_Visitor.Animals
{
    public class Monkey : IAnimal
    {
        public void Shout()
        {
            Console.WriteLine("Ooohh o aa aa!");
        }
        public void Accept(IAnimalOperation operation)
        {
            operation.VisitMonkey(this);
        }
    }

    public class Lion : IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("Rooaaar!!");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitLion(this);
        }
    }

    public class Wolf : IAnimal
    {
        public void Grrr()
        {
            Console.WriteLine("Grrrr!!");
        }
        
        public void Accept(IAnimalOperation operation)
        {
            operation.VisitWolf(this);
        }
    }
}