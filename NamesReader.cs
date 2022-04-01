namespace NameReader
{
    internal class NamesReader
    {
        //Считывание имен из исходного файла
        public static List<string> ReadNamesFromFile (string path)
        {
            return File.ReadLines(path).
                Select(s => s.Split(' ').
                First()).ToList();
        }        
    }
}
