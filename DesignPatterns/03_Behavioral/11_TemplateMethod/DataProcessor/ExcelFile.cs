using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._TemplateMethod
{
    public class ExcelFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reads data from excel file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from excel file");
        }
    }
}