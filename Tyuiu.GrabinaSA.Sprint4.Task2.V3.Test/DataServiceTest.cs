using Tyuiu.GrabinaSA.Sprint4.Task2.V3.Lib;
namespace Tyuiu.GrabinaSA.Sprint4.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTEst
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 24;
            Assert.AreEqual(res, wait);
        }
    }
}