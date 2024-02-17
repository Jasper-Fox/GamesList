//Задача создать класс для каждога жанра игр. В классе прописать по 5+ полей разного типа(по возможности) и метод их вывода. Ну и вывести
namespace Games_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPG darkSouls = new RPG();
            darkSouls.Gent = "Action";
            darkSouls.Name = "Dark Souls";            
            darkSouls.Platforms = "PC; PlayStation; 3Xbox 360";
            darkSouls.Year = 2011;
            darkSouls.Developer = "From Software";
            darkSouls.Info();

            Shooter halfLife = new Shooter("Action", "Half-Life", "PC", 1998, "Valve Software");
            halfLife.Info();

            MOBA dOTA = new MOBA();
            dOTA.Name = "DOTA 2";
            dOTA.Platforms = "PC";
            dOTA.Year = 2013;
            dOTA.Developer = "Valve Software";
            dOTA.Info();

            Puzzle two = new Puzzle();
            two.Name = "2023";
            two.Platforms = "PC, Mobile";
            two.Year = 2023;
            two.Developer = "Specter Corporation";
            two.Info();

            Strategy warhammer = new Strategy();
            warhammer.Gent = "Action";
            warhammer.Name = "Total War: Warhammer 3";
            warhammer.Platforms = "PC";
            warhammer.Year = 2022;
            warhammer.Developer = "Creative Assembly";
            warhammer.Info();
        }
    }
}
