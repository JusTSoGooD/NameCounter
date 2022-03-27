using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameReader
{
    internal class TextReader
    {
        //Считывание текста из исходного файла
        public static string ReadingTextFromFile (string path)
        {
            string readedString;
            using (var streamReader = new StreamReader(path))
            {
                readedString = streamReader.ReadToEnd();
            }

            
            return readedString;
        }        
    }
}
