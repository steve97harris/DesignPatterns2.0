using System;
using System.Collections.Generic;

namespace DesignPatterns._ColourPrototype
{
    public class ColourManager
    {
        private Dictionary<string, ColourPrototype> colours = new Dictionary<string,ColourPrototype>();

        public ColourPrototype this[string key]
        {
            get
            {
                return colours[key];
            }
            set
            {
                colours.Add(key,value);
            }
        }
    }
}