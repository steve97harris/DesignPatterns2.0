using System;

namespace DesignPatterns._02_Structural._02_Bridge.WebPage
{
    public class Program
    {
        static void Main()
        {
            var redTheme = new Red();
            var blueTheme = new Blue();
            var blackWhiteTheme = new BlackWhite();
            
            var about = new About(redTheme);
            var careers = new Careers(blueTheme);
            
            Console.WriteLine(about.GetContent());
            Console.WriteLine(careers.GetContent());
        }
    }
}