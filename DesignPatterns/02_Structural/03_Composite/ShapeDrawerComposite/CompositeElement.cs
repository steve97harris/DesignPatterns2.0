﻿using System;
using System.Collections.Generic;

namespace DesignPatterns._Composite
{
    // Composite Class
    public class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();
        
        public CompositeElement(string name) : base(name)
        {
            
        }
        
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + "+ " + name);
            
            // Display each child element on this node
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}