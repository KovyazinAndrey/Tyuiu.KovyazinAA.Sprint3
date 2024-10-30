using Tyuiu.KovyazinAA.Sprint3.Task5.V17.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенные циклы и вычислить сумму ряда     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X = 2                                                                   *");
            Console.WriteLine("* Первый Нижний предел суммирования - 1                                   *");
            Console.WriteLine("* Первый Верхний предел суммирования - 3                                  *");
            Console.WriteLine("* Второй Нижний предел суммирования - 1                                   *");
            Console.WriteLine("* Второй Верхний предел суммирования - 12                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int x = 2;
            int start1 = 1;
            int start2 = 1;
            int end1 = 3;
            int end2 = 12;
            Console.WriteLine(ds.GetSumSumSeries(x,start1,start2,end1,end2));
        }
    }
}
