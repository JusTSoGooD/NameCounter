using System.Text;

namespace NameReader
{
    internal class Namesgenerator
    {
        public static void GenerateNames()
        {
            string path = "C:/Users/kuchm/Desktop/Программы c#/NameReader/test.txt";
            Random random = new();
            StringBuilder sb = new StringBuilder();
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append((char)random.Next(65, 90));
                }

                sb.Append(' ');
                for (int j = 0; j < 3; j++)
                {
                    sb.Append((char)random.Next(65, 90));
                }

                sw.WriteLine(sb.ToString());
                sb.Clear();
            }           

            sw.Close();
        }
    }
}
