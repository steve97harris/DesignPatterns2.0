namespace DesignPatterns._02_Structural._07_Proxy.MathProxy
{
    // Proxy Object Class
    public class MathProxy : IMath
    {
        private Maths maths = new Maths();

        public double Add(double x, double y)
        {
            return maths.Add(x, y);
        }

        public double Sub(double x, double y)
        {
            return maths.Sub(x, y);
        }

        public double Mul(double x, double y)
        {
            return maths.Mul(x, y);
        }

        public double Div(double x, double y)
        {
            return maths.Div(x, y);
        }
    }
}