using System;

namespace DesignPatterns._03_Behavioral._06_Memento.SalesProspects
{
    public class Program
    {
        static void MainOLD()
        {
            SalesProspect salesProspect = new SalesProspect();
            salesProspect.Name = "Stevie Bergweign";
            salesProspect.Phone = "0983290584";
            salesProspect.Budget = 2000000.0;
            
            // Store internal state
            ProspectMemory prospectMemory = new ProspectMemory();
            prospectMemory.Memento = salesProspect.SaveMemento();
            
            // Continue changing originator 
            salesProspect.Name = "Eric Lamela";
            salesProspect.Phone = "439857349857";
            salesProspect.Budget = 1400000.0;
            
            // Restore saved state
            salesProspect.RestoreMemento(prospectMemory.Memento);
            Console.WriteLine(salesProspect.Name);
            
            Console.ReadKey();
        }
    }
}