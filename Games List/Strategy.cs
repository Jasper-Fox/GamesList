namespace Games_List
{
    class Strategy
    {
        private string Tipe = "Strategy";
        public string Gent;
        public string Name;
        public string Platforms;
        public int Year;
        public string Developer;
        public void Info()
        {
            Console.WriteLine("Tipe: " + Tipe + "\n" + "Gent: " + Gent + "\n" + "Name: " + Name + "\n" + "Platforms: " + Platforms + "\n" + "Year: " + Year + "\n" + "Developer: " + Developer + "\n");
        }
    }
}
