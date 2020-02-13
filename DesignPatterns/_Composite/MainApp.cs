using System;
using DesignPatterns._Adapter;

namespace DesignPatterns._Composite
{
    public class MainApp
    {
        public static void MainOLD()
        {
            // Create a tree structure
            CompositeElement root = new CompositeElement("Picture");
            
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            
            // Create a branch
            CompositeElement branch = new CompositeElement("Two Circles");
            branch.Add(new PrimitiveElement("Black Circle"));
            branch.Add(new PrimitiveElement("White Circle"));
            // root.Add(branch);
            
            // Add and remove a PrimitiveElement
            PrimitiveElement primitiveElement = new PrimitiveElement("Yellow Square");
            branch.Add(primitiveElement);
            root.Add(branch);
            root.Display(1);
            
            branch.Remove(primitiveElement);

            // Recursively display nodes
            root.Display(1);
            
            // Wait for user
            Console.ReadKey();
        }
    }
}