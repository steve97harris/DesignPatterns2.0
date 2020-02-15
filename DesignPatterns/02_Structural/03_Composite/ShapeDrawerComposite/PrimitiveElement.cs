using System;

namespace DesignPatterns._Composite
{
    // Leaf Class
    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
            
        }

        public override void Add(DrawingElement c)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(DrawingElement d)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + " " + name);
        }
    }
}