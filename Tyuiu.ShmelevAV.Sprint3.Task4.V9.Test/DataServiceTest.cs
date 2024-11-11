using Tyuiu.ShmelevAV.Sprint3.Task4.V9.Lib;

namespace Tyuiu.ShmelevAV.Sprint3.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 1.708;
            Assert.AreEqual(wait, res);
        }
    }
}