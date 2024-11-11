using Tyuiu.GrabinaSA.Sprint4.Task3.V27.Lib;
namespace Tyuiu.GrabinaSA.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                       { 4, 3, 5, 5, 3 }                                 *");
            Console.WriteLine("*                       { 6, 7, 4, 4, 3 }                                 *");
            Console.WriteLine("*                       { 3, 3, 7, 3, 6 }                                 *");
            Console.WriteLine("*                       { 3, 4, 3, 7, 7 }                                 *");
            Console.WriteLine("*                       { 3, 5, 6, 3, 6 }                                 *");
            Console.WriteLine("***************************************************************************");

            int[,] array = { { 4, 3, 5, 5, 3 },
                             { 6, 7, 4, 4, 3},
                             { 3, 3, 7, 3, 6},
                             { 3, 4, 3, 7, 7 },
                             { 3, 5, 6, 3, 6 } };



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int z = ds.Calculate(array);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
