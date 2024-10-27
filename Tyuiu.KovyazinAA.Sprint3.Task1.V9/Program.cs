using Tyuiu.KovyazinAA.Sprint3.Task1.V9.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла While                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формулe                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X = 5                                                                   *");
            Console.WriteLine("* Нижний предел суммирования - 1                                          *");
            Console.WriteLine("* Верхний предел суммирования - 4                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            int y = 1;
            int z = 4;
            Console.WriteLine(ds.GetMultiplySeries(x, y, z));
        }
    }
}
