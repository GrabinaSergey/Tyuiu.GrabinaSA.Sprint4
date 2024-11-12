using Tyuiu.GrabinaSA.Sprint4.Task6.V10.Lib;
namespace Tyuiu.GrabinaSA.Sprint4.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*                                                                            *");
            string[] i = { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            for (int j = 0; j < i.Length; j++) { Console.Write($"{i[j]}\t"); }
            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("******************************************************************************");
            string[] res = ds.Calculate(i);
            for (int j = 0; j < res.Length; j++) { Console.Write($"{res[j]}\t"); }
            Console.WriteLine();
        }
    }
}
