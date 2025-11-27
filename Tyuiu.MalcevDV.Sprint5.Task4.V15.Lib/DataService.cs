using System.Globalization;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalcevDV.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string read = File.ReadAllText(path);
            double res;
            if (double.TryParse(read, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double parsedValue))
            {
                res = Math.Round((Math.Sin(parsedValue) + ((Math.Pow(parsedValue, 2)) / 2)), 3);
            }
            else
            {
                throw new FormatException("Ввод данных из файла имеет неверный формат.");
            }

            return res;
        }
    }
}
