namespace DesignPatterns._03_Behavioral._10_State.TextEditor
{
    public class Program
    {
        static void MainOLD()
        {
            var editor = new TextEditor();
            
            editor.Type("Hello Steve");        // Default
            
            editor.SetState(new LowerCase());        
            editor.Type("Hi");                // lower 
            
            editor.SetState(new UpperCase());
            editor.Type("Shut up");            // UPPER
        }
    }
}