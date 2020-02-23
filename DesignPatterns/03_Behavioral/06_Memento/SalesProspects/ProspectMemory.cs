namespace DesignPatterns._03_Behavioral._06_Memento.SalesProspects
{
    // Caretaker class
    public class ProspectMemory
    {
        private Memento mMemento;
        
        // Property
        public Memento Memento
        {
            set => mMemento = value;
            get => mMemento;
        }
    }
}