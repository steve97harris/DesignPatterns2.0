using DesignPatterns._Bridge;

namespace DesignPatterns._Flyweight.Flyweight02_TeaShop
{
    public class Program
    {
        public static void Main()
        {
            var teaMaker = new TeaMaker();
            var teaShop = new TeaShop(teaMaker);

            teaShop.TakeOrder("Chamomile", 1);
            teaShop.TakeOrder("Green tea", 2);
            teaShop.TakeOrder("No milk, no sugar", 3);

            teaShop.Serve();
            // Serving tea to table #1
            // Serving tea to table #2
            // Serving tea to table #3
        }
    }
}