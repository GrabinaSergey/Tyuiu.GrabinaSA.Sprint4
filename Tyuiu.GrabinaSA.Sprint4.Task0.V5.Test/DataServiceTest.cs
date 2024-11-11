using Tyuiu.GrabinaSA.Sprint4.Task0.V5.Lib;
namespace Tyuiu.GrabinaSA.Sprint4.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 3, 5, 6, 7, 8, 9, 2 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int a = 20;
            Assert.AreEqual(20, res);
        }
    }
}