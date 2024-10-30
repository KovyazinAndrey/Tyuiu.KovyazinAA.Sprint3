using Tyuiu.KovyazinAA.Sprint3.Task7.V26.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* f(x) = 5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5))                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X принадлежит отрезку [-5;5]                                            *");
            int start = -5;
            int end = 5;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            int len = ds.GetMassFunction(start, end).Length;
            double[] result;
            result = new double[len];
            result = ds.GetMassFunction(start, end);
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,5:f2}   |", start, result[i]);
                start++;
            }
            Console.WriteLine("+----------+----------+");
        }
    }
}
