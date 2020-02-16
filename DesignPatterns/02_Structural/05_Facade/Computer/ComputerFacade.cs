using System;

namespace DesignPatterns._02_Structural._05_Facade.Computer
{
    public class ComputerFacade
    {
        private readonly Computer mComputer;

        public ComputerFacade(Computer computer)
        {
            this.mComputer = computer ?? throw new ArgumentNullException(nameof(computer), "computer cannot be null");        // nameof - outputs the name of the variable, e.g: computer
        }

        public void TurnOn()
        {
            mComputer.GetElectricShock();
            mComputer.MakeSound();
            mComputer.ShowLoadingScreen();
        }

        public void TurnOff()
        {
            mComputer.SaveAll();
            mComputer.ShutDown();
        }

        public void Lock()
        {
            mComputer.Sleep();
            mComputer.ShowLockScreen();
        }
    }
}