namespace NameReader
{
    //Класс, содержащий имя и частоту появления имени в тексте
    internal class Names
    {
        public Names(string firstName, int frequency)
        {
            FirstName = firstName;
            Frequency = frequency;
        }
        public string FirstName { get; set; }
        public int Frequency { get; set; }
    }
}
