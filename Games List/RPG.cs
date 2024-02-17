namespace Games_List
{
    public class RPG
    {
        private string _tipe = "RPG";
        public string gent;
        public string name;
        public string platforms;
        public int year;
        public string developer;
        public void Info()
        {
            Console.WriteLine("Tipe: " + _tipe + "\n" + "Gent: " + gent + "\n" + "Name: " + name + "\n" + "Platforms: " + platforms + "\n" + "Year: " + year + "\n" + "Developer: " + developer + "\n");
        }

    }
}
