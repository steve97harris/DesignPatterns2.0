namespace DesignPatterns._01_Creational._02_Factory.Interviewer
{
    public class Program
    {
        public static void MainOLD()
        {
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();
            
            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview();
        }
    }
}