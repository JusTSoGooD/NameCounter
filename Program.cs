using System;

namespace NameReader
{
    internal class MyProgramm
    {
        static void Main()
        {
            //Namesgenerator.GeneratorOfNames();
            string readedString = TextReader.ReadingTextFromFile("C:/Users/kuchm/Desktop/Программы c#/NameReader/test.txt");
            CountingNames.NamesCounter(readedString);
        }
    }
}
