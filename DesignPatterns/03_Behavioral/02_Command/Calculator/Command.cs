namespace DesignPatterns._03_Behavioral._02_Command.Calculator
{
    // abstract Command Class
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}