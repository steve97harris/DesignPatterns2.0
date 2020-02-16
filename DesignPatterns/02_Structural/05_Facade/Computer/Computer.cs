using System;

namespace DesignPatterns._02_Structural._05_Facade.Computer
{
    public class Computer
    {
        public void GetElectricShock()
        {
            Console.WriteLine("Ouch!!");
        }

        public void MakeSound()
        {
            Console.WriteLine("Beep");
        }

        public void ShowLoadingScreen()
        {
            Console.WriteLine("Loading, Please wait...");    
        }

        public void ShutDown()
        {
            Console.WriteLine("Shutting Down");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzzzzzz");
        }

        public void Download()
        {
            Console.WriteLine("Downloading files...");
        }

        public void SaveAll()
        {
            Console.WriteLine("Saving Work");
        }

        public void ShowLockScreen()
        {
            Console.WriteLine("[Display Sunset Wallpaper]");
        }
    }
}