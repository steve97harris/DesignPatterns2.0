using System;

namespace DesignPatterns._02_Structural._07_Proxy.MathProxy
{
    public class Program
    {
        static void Main()
        {
            MathProxy proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4,2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4,2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4,2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4,2));
            
            Console.ReadKey();
        }
    }
}
