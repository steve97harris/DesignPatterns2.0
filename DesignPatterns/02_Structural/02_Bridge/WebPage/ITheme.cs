namespace DesignPatterns._02_Structural._02_Bridge.WebPage
{
    public interface ITheme
    {
        string GetColour();
    }

    class Red : ITheme
    {
        public string GetColour()
        {
            return "Red theme";
        }
    }

    class Blue : ITheme
    {
        public string GetColour()
        {
            return "Blue theme";
        }
    }

    class BlackWhite : ITheme
    {
        public string GetColour()
        {
            return "Black and White theme";
        }
    }
}