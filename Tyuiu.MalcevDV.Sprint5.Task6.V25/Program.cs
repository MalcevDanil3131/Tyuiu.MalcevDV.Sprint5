using Tyuiu.MalcevDV.Sprint5.Task6.V25.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #5", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #5", width);
PrintCenteredLine("Вариант #15", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Найти минимальное вещественное значение по условию из списка", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
DataService ds = new DataService();
string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";

Console.WriteLine(new string('*', width));
PrintCenteredLine($"Результат: {ds.LoadFromDataFile(path)}", width);

Console.WriteLine(new string('*', width));