using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalcevDV.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string a = File.ReadAllText(path);
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i - 1] && a[i] == 'с' || a[i] == 'С' && a[i - 1] == 'с' || a[i] == 'с' && a[i - 1] == 'С')

                {
                    a = a.Remove(i, 1);
                }
            }
            string dir = Path.GetTempPath();
            string file = Path.Combine(dir, "OutPutDataFileTask7V20.txt");
            File.WriteAllText(file, a);
            return file;
        }
    }
}
