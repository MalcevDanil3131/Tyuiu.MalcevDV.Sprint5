using Tyuiu.MalcevDV.Sprint5.Task0.V18.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #5", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #0", width);
PrintCenteredLine("Вариант #18", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, подсчитывающую сумму нечетных элементов массива", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
DataService ds = new DataService();
int x = 3;
string result = ds.SaveToFileTextData(x);

if (result.StartsWith("Ошибка:"))
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine($"файл: {result}");
    Console.WriteLine(new string('*', width));
}
Console.WriteLine(new string('*', width));
Console.WriteLine(new string('*', width));