namespace DesignPatterns._03_Behavioral._08_Visitor.Animals
{
    public class Program
    {
        static void MainOLD()
        {
            var monkey = new Monkey();
            var lion = new Lion();
            var wolf = new Wolf();
            
            var speak = new Speak();
            var jump = new Jump();
            
            monkey.Accept(speak);
            monkey.Accept(jump);
            
            lion.Accept(speak);
            lion.Accept(jump);
            
            wolf.Accept(speak);
            wolf.Accept(jump);
        }
    }
}