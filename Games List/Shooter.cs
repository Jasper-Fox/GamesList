namespace Games_List
{
    class Shooter
    {
        private string Tipe = "Shooter";
        public readonly string Gent;
        public readonly string Name;
        public readonly string Platforms;
        public readonly int Year;
        public readonly string Developer;

        public Shooter(string gent, string name, string platforms, int year, string developer)
        {
            Gent = gent;
            Name = name;
            Platforms = platforms;
            Year = year;
            Developer = developer;
        }
        public void Info()
        {
            Console.WriteLine("Tipe: " + Tipe + "\n" + "Gent: " + Gent + "\n" + "Name: " + Name + "\n" + "Platforms: " + Platforms + "\n" + "Year: " + Year + "\n" + "Developer: " + Developer + "\n");
        }
    }
}
