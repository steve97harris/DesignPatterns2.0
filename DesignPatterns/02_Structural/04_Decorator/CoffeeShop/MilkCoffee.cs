using System;

namespace DesignPatterns._02_Structural._04_Decorator.CoffeeShop
{
    public class MilkCoffee : ICoffee
    {
        private ICoffee mCoffee;

        public MilkCoffee(ICoffee coffee)
        {
            this.mCoffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");        // Throws left hand operation as long as coffee not null.
        }

        public int GetCost()
        {
            return mCoffee.GetCost() + 1;
        }

        public string GetDescription()
        {
            return String.Concat(mCoffee.GetDescription(), " plus Milk");        // Concat - link together in a chain or series. 
        }
    }

    public class VanillaTurmericCoffee : ICoffee
    {
        private ICoffee mCoffee;

        public VanillaTurmericCoffee(ICoffee coffee)
        {
            this.mCoffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
        }

        public int GetCost()
        {
            return mCoffee.GetCost() + 2;
        }
        
        public string GetDescription()
        {
            return String.Concat(mCoffee.GetDescription(), " plus Vanilla and Turmeric");        // Concat - link together in a chain or series. 
        }
    }

    public class MilkSugarCoffee : ICoffee
    {
        private ICoffee mCoffee;

        public MilkSugarCoffee(ICoffee coffee)
        {
            this.mCoffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
        }

        public int GetCost()
        {
            return mCoffee.GetCost() + 2;
        }

        public string GetDescription()
        {
            return String.Concat(mCoffee.GetDescription(), " plus Milk and Sugar");        // Concat - link together in a chain or series. 
        }
    }
}