using System;

namespace DesignPatterns._Proxy.Proxy01_Door
{
    public class SecuredDoor
    {
        private IDoor mDoor;

        public SecuredDoor(IDoor door)
        {
            mDoor = door ?? throw new ArgumentNullException("door", "door can not be null");
        }

        public void Open(string password)
        {
            if (Authenticate(password))
            {
                mDoor.Open();
            }
            else
            {
                Console.WriteLine("Invalid Password");       
            }
        }

        private bool Authenticate(string password)
        {
            return password == "pa55word";
        }
        
        public void Close()
        {
            mDoor.Close();
        }
    }
}