using Tyuiu.GrabinaSA.Sprint4.Task6.V10.Lib;
namespace Tyuiu.GrabinaSA.Sprint4.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] i = { "Òåàòð", "Êèíî", "Ìóçåé", "Ïàðê", "Çîîïàðê", "Êîíöåðò", "Âûñòàâêà" };
            string[] j = ds.Calculate(i);
            string[] k = { "Òåàòð", "Êèíî", "Ìóçåé", "Ïàðê" };
            CollectionAssert.AreEqual(k, j);
        }
    }
}