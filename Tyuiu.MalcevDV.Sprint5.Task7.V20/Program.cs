using Tyuiu.MalcevDV.Sprint5.Task7.V20.Lib;
using System;

namespace Tyuiu.MalcevDV.Sprint5.Task7.V20
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:5.7.v20| Мальцев Д.В., РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Мальцев Данил Вячеславович |  РППб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:          *\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* File = " + Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V20.txt"));

            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.LoadDataAndSave(Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V20.txt"));
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Result in {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}