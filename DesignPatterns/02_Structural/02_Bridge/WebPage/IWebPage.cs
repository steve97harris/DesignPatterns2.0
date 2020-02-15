namespace DesignPatterns._02_Structural._02_Bridge.WebPage
{
    public interface IWebPage
    {
        string GetContent();
    }

    class About : IWebPage
    {
        protected ITheme theme;

        public About(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"About section in {theme.GetColour()}";
        }
    }

    class Careers : IWebPage
    {
        protected ITheme theme;

        public Careers(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"Careers section in {theme.GetColour()}";
        }
    }
}