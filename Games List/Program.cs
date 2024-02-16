using System.Xml.Linq;
using System;
//Задача создать класс для каждога жанра игр. В классе прописать по 5+ полей разного типа(по возможности) и метод их вывода. Ну и вывести
namespace Games_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPG DarkSouls = new RPG();
            DarkSouls.Gent = "Action";
            DarkSouls.Name = "Dark Souls";            
            DarkSouls.Platforms = "PC; PlayStation; 3Xbox 360";
            DarkSouls.Year = 2011;
            DarkSouls.Developer = "From Software";
            DarkSouls.Info();

            Shooter HalfLife = new Shooter("Action", "Half-Life", "PC", 1998, "Valve Software");
            HalfLife.Info();

            MOBA DOTA = new MOBA();
            DOTA.Name = "DOTA 2";
            DOTA.Platforms = "PC";
            DOTA.Year = 2013;
            DOTA.Developer = "Valve Software";
            DOTA.Info();

            Puzzle Two = new Puzzle();
            Two.Name = "2023";
            Two.Platforms = "PC, Mobile";
            Two.Year = 2023;
            Two.Developer = "Specter Corporation";
            Two.Info();

            Strategy Warhammer = new Strategy();
            Warhammer.Gent = "Action";
            Warhammer.Name = "Total War: Warhammer 3";
            Warhammer.Platforms = "PC";
            Warhammer.Year = 2022;
            Warhammer.Developer = "Creative Assembly";
            Warhammer.Info();
        }
    }

    class RPG
    {
        private string Tipe = "RPG";
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

    class Shooter
    {
        private string Tipe = "Shooter";
        public string Gent;
        public string Name;
        public string Platforms;
        public int Year;
        public string Developer;

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

    class Puzzle
    {
        private string Tipe = "Puzzle";
        public string Name;
        public string Platforms;
        public int Year;
        public string Developer;
        public void Info()
        {
            Console.WriteLine("Tipe: " + Tipe + "\n" + "Name: " + Name + "\n" + "Platforms: " + Platforms + "\n" + "Year: " + Year + "\n" + "Developer: " + Developer + "\n");
        }
    }

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
