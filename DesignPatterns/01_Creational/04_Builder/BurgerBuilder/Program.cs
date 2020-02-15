using System;

namespace DesignPatterns._01_Creational._04_Builder.BurgerBuilder
{
    public class Program
    {
        public static void MainOLD()
        {
            var burger = new BurgerBuilder(6).AddCheese().AddLettuce().AddPepporoni().AddTomato().Build();
            Console.WriteLine(burger.GetDescription());
        }
    }
}