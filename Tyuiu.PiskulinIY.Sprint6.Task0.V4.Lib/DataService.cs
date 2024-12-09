using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PiskulinIY.Sprint6.Task0.V4.Lib

{
    public class DataService : ISprint6Task0V4
    {
        public double Calculate(int x)
        {
            double res = Math.Pow(x,3)*2.4+Math.Pow(x,2)*0.4-1.4*x+4.1;
            return Math.Round(res,3);

        }
    }
}
