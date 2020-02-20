using System;

namespace DesignPatterns._03_Behavioral._10_State.TextEditor
{
    public interface IWritingState
    {
        void Write(string words);        // Interface function to write words
    }

    public class UpperCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToUpper());        // Write words in upper case.
        }
    }

    public class LowerCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());        // Write words in lower case. 
        }
    }

    public class DefaultText : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);                // Write words in default text. 
        }
    }
}