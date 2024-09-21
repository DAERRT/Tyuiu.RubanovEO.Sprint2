
using Tyuiu.RubanovEO.Sprint2.Task4.V16.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Рубанов Е. О. | ПКТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор.                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Рубанов Егор Олегович | ПКТБ-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать  программу которая вычисляет требуемое значение с ипользованием*");
            Console.WriteLine("* Тернарного оператора, где пользователь вводит значение переменных x,y с *");
            Console.WriteLine("* клавиатуры.                                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();

        }
    }
}
