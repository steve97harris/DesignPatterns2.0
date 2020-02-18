namespace DesignPatterns._03_Behavioral._05_Mediator.Chatroom
{
    public class User
    {
        private string mName;
        private IChatRoomMediator mChatRoom;

        public User(string name, IChatRoomMediator chatroom)
        {
            this.mName = name;
            this.mChatRoom = chatroom;
        }
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