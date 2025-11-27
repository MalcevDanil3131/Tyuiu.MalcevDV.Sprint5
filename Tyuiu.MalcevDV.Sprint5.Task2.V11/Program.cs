using Tyuiu.MalcevDV.Sprint5.Task2.V11.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #5", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #1", width);
PrintCenteredLine("Вариант #20", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Записать результат функции в текстовый файл в виде таблицы", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
int[,] matrix = new int[3, 3];

Console.WriteLine("* Ввод массива:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Введите элемент [{i}, {j}]: ");
        matrix[i, j] = int.Parse(Console.ReadLine() ?? "0");
    }
}

DataService dataService = new DataService();
string filePath = dataService.SaveToFileTextData(matrix);

Console.WriteLine("\nрезультат сохранен в :" + filePath );
Console.ReadKey();
Console.WriteLine(new string('*', width));