namespace DesignPatterns._03_Behavioral._02_Command.LightBulb
{
    public class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}