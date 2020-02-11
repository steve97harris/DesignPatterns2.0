using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._TemplateMethod
{
    public class ExcelFile
    {
        public void ReadData()
        {
            Console.WriteLine("Reads data from excel file");
        }

        public void ProcessData()
        {
            Console.WriteLine("Process data from excel file");
        }

        public void SaveData()
        {
            Console.WriteLine("Saves data to database");
        }
    }
}