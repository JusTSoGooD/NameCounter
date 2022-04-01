namespace NameReader
{
    internal static class CountNames
    {      
        //Получение списка уникальных имен
        private static List<Names> GetUniqueNames(List<string> namesReadedFromFile)
        {
            HashSet<string> namesList = namesReadedFromFile.ToHashSet();
            List<Names> uniqueNames = new();
            foreach (var name in namesList)
            {
                uniqueNames.Add(new Names(name, 0));
            }

            return uniqueNames;
        }

        //Получение информации о количестве появлений уникальных имен в исходном файле
        private static List<Names> CountFrequencyOfNames(List<string> namesReadedFromFile, List<Names> uniquenames)
        {
            foreach (var name in namesReadedFromFile)
            {
                for (int i = 0; i < uniquenames.Count; i++)
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
        private static void OutputMostCommonNames(List<Names> namesWithCountOfCommon)
        {
            int maxCount = namesWithCountOfCommon.Max(x => x.Frequency);
            foreach (Names name in namesWithCountOfCommon.Where(x => x.Frequency == maxCount))
            {
                Console.WriteLine($"Самое часто встречающееся имя {name.FirstName} с частотой {name.Frequency}");
            }
        }

        //Обертка для внутренностей класса
        public static void FindMostCommonNames(List<string> namesReadedFromFile)
        {
            List<Names> uniqueNames = GetUniqueNames(namesReadedFromFile);
            List<Names> namesWithCountOfCommon = CountFrequencyOfNames(namesReadedFromFile, uniqueNames);
            OutputMostCommonNames(namesWithCountOfCommon);
        }

        
    }
}
