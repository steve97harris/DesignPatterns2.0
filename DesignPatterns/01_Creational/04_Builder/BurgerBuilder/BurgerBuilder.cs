﻿namespace DesignPatterns._01_Creational._04_Builder.BurgerBuilder
{
    public class BurgerBuilder
    {
        public int Size;
        public bool Cheese;
        public bool Pepporoni;
        public bool Lettuce;
        public bool Tomato;

        public BurgerBuilder(int size)
        {
            this.Size = size;
        }

        public BurgerBuilder AddCheese()
        {
            this.Cheese = true;
            return this;
        }

        public BurgerBuilder AddPepporoni()
        {
            this.Pepporoni = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            this.Lettuce = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            this.Tomato = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }
    }
}