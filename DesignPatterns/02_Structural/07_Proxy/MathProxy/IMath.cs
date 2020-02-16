namespace DesignPatterns._02_Structural._07_Proxy.MathProxy
{
    // Subject interface
    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}