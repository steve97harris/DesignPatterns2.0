using System;
using System.Collections.Generic;

namespace DesignPatterns._Flyweight.Flyweight02_TeaShop
{
    public class TeaShop
    {
        private Dictionary<int, KarakTea> mOrders = new Dictionary<int, KarakTea>();        // Key: integer number, Value: KarakTea
        private readonly TeaMaker mTeaMaker;        // readonly, defines a read only field in our application. 

        public TeaShop(TeaMaker teaMaker)
        {
            mTeaMaker = teaMaker ?? throw new ArgumentNullException("teaMaker", "teaMaker cannot be null");
            // Returns value to it's left-hand operand if it isn't null; otherwise evaluates the right-hand operand and returns its result.
            // Therefore, returns teaMaker as long as it isn't null.
        }

        public void TakeOrder(string teaType, int tableNumber)
        {
            mOrders[tableNumber] = mTeaMaker.Make(teaType);
        }

        public void Serve()
        {
            foreach (var tableNumber in mOrders.Keys)
            {
                Console.Write($"Serving tea to table # {tableNumber}" + "\n");
            }
        }
    }
}