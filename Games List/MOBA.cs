namespace Games_List
{
    class MOBA
    {
        private string Tipe = "MOBA";
        public string Name;
        public string Platforms;
        public int Year;
        public string Developer;
        public void Info()
        {
            Console.WriteLine("Tipe: " + Tipe + "\n" + "Name: " + Name + "\n" + "Platforms: " + Platforms + "\n" + "Year: " + Year + "\n" + "Developer: " + Developer + "\n");
        }

    }
}
