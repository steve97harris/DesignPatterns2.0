using System;
using System.Collections.Generic;

namespace DesignPatterns._Adapter
{
    public class ChemicalDatabankMain
    {
        public static void MainOld()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            Compound benzene = new RichCompound("Benzene");
            Compound ethanol = new RichCompound("Ethanol");
            
            unknown.Display();
            water.Display();
            benzene.Display();
            ethanol.Display();

            Console.ReadKey();
        }
    }
}