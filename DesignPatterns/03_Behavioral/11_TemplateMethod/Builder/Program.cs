namespace DesignPatterns._03_Behavioral._11_TemplateMethod.Builder
{
    public class Program
    {
        static void Main()
        {
            var androidBuilder = new AndroidBuilder();
            androidBuilder.Build();
            
            var iosBuilder = new IOS();
            iosBuilder.Build();
        }
    }
}