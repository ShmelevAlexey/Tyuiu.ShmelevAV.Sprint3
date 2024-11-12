using Tyuiu.ShmelevAV.Sprint3.Task6.V4.Lib;

namespace Tyuiu.ShmelevAV.Sprint3.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 14;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}