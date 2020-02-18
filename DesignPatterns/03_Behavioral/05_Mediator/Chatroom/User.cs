using DesignPatterns._basicconcepts;

namespace DesignPatterns._03_Behavioral._05_Mediator.Chatroom
{
    public class User
    {
        // Colleague
        private string mName;
        protected IChatRoomMediator mChatRoom;

        public User(string name, IChatRoomMediator chatroom)
        {
            this.mName = name;
            this.mChatRoom = chatroom;
        }
        
        // Concrete Colleague
        public string GetName()
        {
            return mName;
        }

        public void Send(string message)
        {
            mChatRoom.ShowMessage(this,message);
        }
    }
}