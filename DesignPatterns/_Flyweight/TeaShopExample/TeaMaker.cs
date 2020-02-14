using System;
using System.Collections.Generic;

namespace DesignPatterns._Flyweight.TeaShopExample
{
    // Anything that will be cached is flyweight.
    // Types of tea here will be flyweights.
    
    // TeaMaker acts as a factory and saves the tea.
    public class TeaMaker
    {
        protected Dictionary<string, string> availableTea = new Dictionary<string, string>();

        public void makeTea(string preference)
        {
            if (this.availableTea[preference] == null)
            {
                this.availableTea[preference] = new KarakTea();
            }

            return this.availableTea[preference];
        }
    }

    public class KarakTea
    {
        
    }
}