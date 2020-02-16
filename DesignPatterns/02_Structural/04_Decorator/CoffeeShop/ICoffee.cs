namespace DesignPatterns._02_Structural._04_Decorator.CoffeeShop
{
    public interface ICoffee
    {
        int GetCost();
        string GetDescription();
    }

    class SimpleCoffee : ICoffee
    {
        public int GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Simple Black Coffee";
        }
    }
}