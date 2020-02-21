using System;
using DesignPatterns._basicconcepts;

namespace DesignPatterns._03_Behavioral._11_TemplateMethod.Builder
{
    class AndroidBuilder : Builder
    {
        public override void CompileCode()
        {
            Console.WriteLine("Writing Android code");
        }

        public override void Test()
        {
            Console.WriteLine("QA Testing subject to android standards");
        }

        public override void BugFixes()
        {
            Console.WriteLine("Fixing any bugs and issues");
        }

        public override void Assemble()
        {
            Console.WriteLine("Assembling the final build");
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploying the software to android machines");
        }
    }

    class IOS : Builder
    {
        public override void CompileCode()
        {
            Console.WriteLine("Compiling iOS code");
        }

        public override void Test()
        {
            Console.WriteLine("QA testing subject to iOS standards");
        }

        public override void BugFixes()
        {
            Console.WriteLine("Fixing any bugs and issues");
        }

        public override void Assemble()
        {
            Console.WriteLine("Assembling the final build");
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploying the software to iOS machines");
        }
    }
}