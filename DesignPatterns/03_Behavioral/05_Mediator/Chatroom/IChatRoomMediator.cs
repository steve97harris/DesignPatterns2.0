using System;

namespace DesignPatterns._03_Behavioral._05_Mediator.Chatroom
{
    // Mediator
    public interface IChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }

    // ConcreteMediator
    public class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd MMMM yyyy, H:mm")} [{user.GetName()}]: {message}");
        }
    }
}