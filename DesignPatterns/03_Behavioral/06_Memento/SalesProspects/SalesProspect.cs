using System;

namespace DesignPatterns._03_Behavioral._06_Memento.SalesProspects
{
    // Originator class
    public class SalesProspect
    {
        private string mName;
        private string mPhone;
        private double mBudget;

        // Gets or sets name
        public string Name
        {
            get { return mName; }
            set
            {
                mName = value;
                Console.WriteLine("Name: " + mName);
            }
        }

        // Gets or sets phone
        public string Phone
        {
            get { return mPhone; }
            set
            {
                mPhone = value;
                Console.WriteLine("Phone: " + mPhone);
            }
        }
        
        // Gets or sets budget
        public double Budget
        {
            get { return mBudget; }
            set
            {
                mBudget = value;
                Console.WriteLine("Budget: " + mBudget);
            }
        }

        // Stores memento
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(mName, mPhone, mBudget);
        }
        
        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring memento --\n");
            this.mName = memento.Name;
            this.mPhone = memento.Phone;
            this.mBudget = memento.Budget;
        }
    }
}