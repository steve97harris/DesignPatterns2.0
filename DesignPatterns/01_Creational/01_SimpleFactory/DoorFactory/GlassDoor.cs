namespace DesignPatterns._01_Creational._01_SimpleFactory.DoorFactory
{
    public class GlassDoor : IDoor
    {
        private int Height
        {
            get;
            set;
        }

        private int Width
        {
            get;
            set;
        }

        public GlassDoor(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int GetHeight()
        {
            return this.Height;
        }

        public int GetWidth()
        {
            return this.Width;
        }
    }
}