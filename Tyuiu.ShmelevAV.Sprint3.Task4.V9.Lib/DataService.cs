using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShmelevAV.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res = res * (x / (Math.Cos(x) - x));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
