using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameReader
{
    internal static class CountingNames
    {
        //Вычленение имен из исходного текстового файла
        private static IEnumerable<string> StringSplitter(string readedString)
        {
            var names = readedString.Split(new string[2] { "\r\n", " " }, StringSplitOptions.None).Where((c, i) => i % 2 == 0);            
            return names;
        }

        //Получение списка уникальных имен
        private static Names[] LookForUniqueNamesWithCount(IEnumerable<string> names)
        {
            HashSet<string> namesList = names.ToHashSet();
            Names[] uniqueNames = new Names[namesList.Count];
            int i = 0;
            foreach (var name in namesList)
            {
                uniqueNames[i++] = new Names(name, 0);
            }
           
            return uniqueNames;
        }

        //Получение информации о количестве появлений уникальных имен в исходном файле
        private static Names[] CountingFrequencyOfNames (IEnumerable<string> names, Names[] uniquenames)
        {
            foreach (var name in names)
            {
                for (int i = 0; i < uniquenames.Length; i++)
                {
                    if (uniquenames[i].FirstName == name)
                    {
                        uniquenames[i].Frequency++;
                    }
                }
            }

            return uniquenames;
        }

        //Вывод наиболее часто встречающихся имен
        private static void OutputMostCommonNames(Names[] namesWithCountOfCommon)
        {
            int maxCount = 0;
            foreach (Names name in namesWithCountOfCommon.Where(x => x.Frequency > maxCount))
            {
                maxCount = name.Frequency;
            }

            foreach (Names name in namesWithCountOfCommon.Where(x => x.Frequency == maxCount))
            {
                Console.WriteLine($"Самое часто встречающееся имя {name.FirstName} с частотой {name.Frequency}");
            }
        }

        //Обертка для внутренностей класса
        public static void NamesCounter(string readedString)
        {
            IEnumerable<string> names = StringSplitter(readedString);
            Names[] uniqueNames = LookForUniqueNamesWithCount(names);
            Names[] namesWithCountOfCommon = CountingFrequencyOfNames(names, uniqueNames);
            OutputMostCommonNames(namesWithCountOfCommon);
        }

        
    }
}
