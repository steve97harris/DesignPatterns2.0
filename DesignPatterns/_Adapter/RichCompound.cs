using System;
using System.Collections.Generic;

namespace DesignPatterns._Adapter
{
    // Adapter Class
    public class RichCompound : Compound
    {
        private ChemicalDataBank bank;

        public RichCompound(string name) : base(name)
        {
            
        }

        public override void Display()
        {
            bank = new ChemicalDataBank();

            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);
            
            base.Display();
            
            Console.WriteLine("Boiling Point: {0}", boilingPoint);
            Console.WriteLine("Melting Point: {0}", meltingPoint);
            Console.WriteLine("Weight: {0}", molecularWeight);
            Console.WriteLine("Formula: {0}", molecularFormula);
        }
    }
}