﻿namespace DesignPatterns._Adapter
{
    // Adaptee Class
    public class ChemicalDataBank
    {
        // Critical Point for melting and boiling (databank)
        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water":
                        return 0.0f;
                    case "benzene":
                        return 5.5f;
                    case "ethanol":
                        return -114.1f;
                    default :
                        return 0f;
                }
            }
            // Boiling Point
            else
            {
                switch (compound.ToLower())
                {
                    case "water" :
                        return 100.0f;
                    case "benzene" :
                        return 80.1f;
                    case "ethanol" :
                        return 78.3f;
                    default :
                        return 0f;
                }
            }
        }
        
        // Molecular Weight (databank)
        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water" :
                    return 18.015;
                case "benzene" :
                    return 78.1134;
                case "ethanol" :
                    return 46.0688;
                default :
                    return 0;
            }
        }
        
        //Molecular Structure (databank)
        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water" :
                    return "H20";
                case "benzene" :
                    return "C6H6";
                case "ethanol" :
                    return "C2H5OH";
                default :
                    return "";
            }
        }
    }
}