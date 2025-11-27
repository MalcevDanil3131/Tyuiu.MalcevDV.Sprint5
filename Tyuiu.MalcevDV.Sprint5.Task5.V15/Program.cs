using Tyuiu.MalcevDV.Sprint5.Task5.V15.Lib;
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
string path = @"C:\DataSprint5\InPutDataFileTask5V15.txt";

Console.WriteLine(new string('*', width));
PrintCenteredLine("Результат:", width);
try
{
    double result = ds.LoadFromDataFile(path);
    Console.WriteLine($"Минимальное значение, делящееся на 5: {result}");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Файл не найден. Убедитесь, что указали правильный путь.");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}

Console.WriteLine(new string('*', width));