
namespace DesignPatterns._Proxy.Proxy01_Door
{
    public class Program
    {
        public static void Main()
        {
            var door = new SecuredDoor(new LabDoor());
            door.Open("laskdjf"); 
            door.Open("pa55word");
            
            door.Close();
        }
    }
}