namespace DesignPatterns._03_Behavioral._05_Mediator.Chatroom
{
    public class Program
    {
        static void Main()
        {
            var mediator = new ChatRoom();
            
            var robert = new User("Robert", mediator);
            var bill = new User("Bill", mediator);
            
            robert.Send("Hi guys");
            bill.Send("Hi Robert");
        }
    }
}