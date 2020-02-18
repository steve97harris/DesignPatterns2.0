namespace DesignPatterns._03_Behavioral._06_Memento.Editor
{
    public class EditorMemento
    {
        private string mContent;

        public EditorMemento(string content)
        {
            this.mContent = content;
        }

        public string Content
        {
            get { return mContent; }
        }
    }
}