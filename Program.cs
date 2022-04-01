namespace NameReader
{
    internal class MyProgramm
    {
        static void Main()
        {
            Namesgenerator.GenerateNames();
            List<string> namesInfile = NamesReader.ReadNamesFromFile("C:/Users/kuchm/Desktop/Программы c#/NameReader/test.txt");
            CountNames.FindMostCommonNames(namesInfile);
        }
    }
}
