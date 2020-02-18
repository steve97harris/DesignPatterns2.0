using System;

namespace DesignPatterns._03_Behavioral._06_Memento.Editor
{
    public class Program
    {
        static void MainOLD()
        {
            var editor = new Editor();
            
            editor.Type("Sentence 1!!");       // Adding two sentences.
            editor.Type("Sentence 2!");
            editor.Save();                            // Saving sentences.
            
            editor.Type("Sentence 3!");        // Adding third sentence.
            
            Console.WriteLine(editor.Content);        // Displays all 3 sentences.
            
            editor.Restore();                         // Restores to last save.
            
            Console.WriteLine(editor.Content);        // Displays original 2 sentences.
        }
    }
}