using System.Collections.Generic;

namespace DesignPatterns._Flyweight.Flyweight02_TeaShop
{
    // Acts as factory and saves the tea
    public class TeaMaker
    {
        private Dictionary<string,KarakTea> mAvailableTea = new Dictionary<string, KarakTea>();
        //Represents collection of Keys and Values.
        // Key: string, Value: KarakTea

        public KarakTea Make(string preference)         // Function Make() belonging to KarakTea
        {
            if (!mAvailableTea.ContainsKey(preference))
            {
                mAvailableTea[preference] = new KarakTea();
            }

            return mAvailableTea[preference];
        }
    }

    // Anything that will be cached is flyweight.
    // Here, types of tea will be flyweights.
    public class KarakTea
    {
        
    }
}