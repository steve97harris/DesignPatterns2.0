namespace DesignPatterns._03_Behavioral._10_State.TextEditor
{
    public class TextEditor
    {
        private IWritingState mState;

        // Constructor - A method that is called whenever an instance of the class is created. 
        public TextEditor()        // Constructs a Text Editor
        {
            mState = new DefaultText();        // Sets writing state to default
        }

        public void SetState(IWritingState state)
        {
            mState = state;                // Sets the writing state to whichever state you like e.g: SetState(Upper case) 
        }

        public void Type(string words)
        {
            mState.Write(words);            // Function to type words in whichever state you chose. 
        }
    }
}