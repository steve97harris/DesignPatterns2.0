using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._TemplateMethod
{
    public class TextFile : DataProcessor
    {

        public override void ReadData()
        {
            Console.WriteLine("Reads data from text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from text file");
        }
    }
}