using Tyuiu.ShmelevAV.Sprint3.Task1.V8.Lib;

namespace Tyuiu.ShmelevAV.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = -302185.684;

            Assert.AreEqual(wait, res);
        }
    }
}