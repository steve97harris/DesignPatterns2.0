using System;

namespace DesignPatterns._03_Behavioral._06_Memento.Editor
{
    public class Editor
    {
        private string mContent = string.Empty;
        private EditorMemento memento;

        public Editor()
        {
            memento = new EditorMemento(string.Empty);
        }

        public void Type(string words)
        {
            mContent = String.Concat(mContent," ", words);        // Link together content and words.
        }

        public string Content
        {
            get { return mContent; }
        }

        public void Save()            // Saves current content
        {
            memento = new EditorMemento(mContent);
        }

        public void Restore()                // Restores content to last save()
        {
            mContent = memento.Content;
        }
    }
}