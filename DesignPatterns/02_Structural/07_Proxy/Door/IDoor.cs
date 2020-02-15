using System;

namespace DesignPatterns._Proxy.Proxy01_Door
{
    public interface IDoor
    {
        void Open();
        void Close();
    }

    class LabDoor : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Lab Door Open");
        }

        public void Close()
        {
            Console.WriteLine("Lab Door Closed");
        }
    }
}