using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._TemplateMethod
{
    public class TextFile
    {
        public void ReadData()
        {
            Console.WriteLine("Reads data from text file");
        }

        public void ProcessData()
        {
            Console.WriteLine("Process data from text file");
        }

        public void SaveData()
        {
            Console.WriteLine("Saves data to database");
        }
    }
}