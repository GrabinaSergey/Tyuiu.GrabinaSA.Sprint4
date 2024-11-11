using Tyuiu.GrabinaSA.Sprint4.Task0.V5.Lib;
namespace Tyuiu.GrabinaSA.Sprint4.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Сумма четных элементов массива: " + ds.GetSumEvenArrEl(numsArray));


            Console.ReadKey();
        }
    }
}
