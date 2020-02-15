using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._TemplateMethod
{
    public abstract class DataProcessor
    {
        public void ReadProcessSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        public abstract void ReadData();
        public abstract void ProcessData();
        
        public void SaveData()
        {
            Console.WriteLine("Saves data to database");
        }
    }
}