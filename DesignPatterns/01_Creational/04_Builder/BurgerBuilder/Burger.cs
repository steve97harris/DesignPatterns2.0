using System.Text;

namespace DesignPatterns._01_Creational._04_Builder.BurgerBuilder
{
    public class Burger
    {
        private int mSize;
        private bool mCheese;
        private bool mPepporoni;
        private bool mLettuce;
        private bool mTomato;

        public Burger(BurgerBuilder builder)
        {
            this.mSize = builder.Size;
            this.mCheese = builder.Cheese;
            this.mPepporoni = builder.Pepporoni;
            this.mLettuce = builder.Lettuce;
            this.mTomato = builder.Tomato;
        }

        public string GetDescription()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"This is {this.mSize} inch Burger. \n");
            stringBuilder.Append($"Cheese: {this.mCheese} \n");
            stringBuilder.Append($"Pepporoni: {this.mPepporoni} \n");
            stringBuilder.Append($"Lettuce: {this.mLettuce} \n");
            stringBuilder.Append($"Tomato: {this.mTomato} \n");
            return stringBuilder.ToString();
        }
    }
}