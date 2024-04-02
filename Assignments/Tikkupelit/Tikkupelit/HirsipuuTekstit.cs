using System;
namespace Tikkupelit
{
	public class HirsipuuTekstit
	{
        string[] hirsipuuSanat = {"maailma", "turismi", "paristo", "uutinen",
            "joutsen", "puhelin", "haamu", "rauta", "kupari", "porras", "koira",
            "vasama", "sementti", "kurpitsa", "vaari", "harmaa", "kallio", "vuoristo"};

        // Lista pelin eri tiloista
		public List<string> hirsipuuTilanteet = new List<string>();

        string mode1 = ("*             *\n" +
                       "*             *\n" +
                       "*             *\n" +
                       "*             *\n" +
                       "*             *\n" +
                       "*             *\n" +
                       "*_____________*");
        string mode2 = ("*             *\n" +
                        "*             *\n" +
                        "*             *\n" +
                        "*             *\n" +
                        "*             *\n" +
                        "*  _________  *\n" +
                        "*__|_______|__*");
        string mode3 = ("*             *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |________  *\n" +
                        "*__|_______|__*");
        string mode4 = ("*  _______    *\n" +
                        "*  |/         *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |________  *\n" +
                        "*__|_______|__*");
        string mode5 = ("*  _______    *\n" +
                        "*  |/   |     *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |________  *\n" +
                        "*__|_______|__*");
        string mode6 = ("*  _______    *\n" +
                        "*  |/   |     *\n" +
                        "*  |    o     *\n" +
                        "*  |          *\n" +
                        "*  |          *\n" +
                        "*  |________  *\n" +
                        "*__|_______|__*");
        string mode7 = ("*  _______    *\n" +
                        "*  |/   |     *\n" +
                        "*  |    o     *\n" +
                        "*  |    |     *\n" +
                        "*  |          *\n" +
                        "*  |________  *\n" +
                        "*__|_______|__*");
        string mode8 = ("*  _______    *\n" +
                        "*  |/   |     *\n" +
                        "*  |    o     *\n" +
                        "*  |    |     *\n" +
                        "*  |   / \\   *\n" +
                        "*  |________  *\n" +
                        "*__|_______|__*");
        string mode9 = ("*  _______    *\n" +
                        "*  |/   |     *\n" +
                        "*  |    o     *\n" +
                        "*  |   /|\\    *\n" +
                        "*  |   / \\    *\n" +
                        "*  |________  *\n" +
                        "*__|_______|__*\n" +
                        "---Game Over---");
        
        public void HirsipuuAsetus()
        {
            hirsipuuTilanteet.Add(mode1);
            hirsipuuTilanteet.Add(mode2);
            hirsipuuTilanteet.Add(mode3);
            hirsipuuTilanteet.Add(mode4);
            hirsipuuTilanteet.Add(mode5);
            hirsipuuTilanteet.Add(mode6);
            hirsipuuTilanteet.Add(mode7);
            hirsipuuTilanteet.Add(mode8);
            hirsipuuTilanteet.Add(mode9);
        }

        public void HirsipuuPiirtaja(int nykyinenTila)
        {
            Console.WriteLine(hirsipuuTilanteet[nykyinenTila]);
            Console.WriteLine();
        }

        public string HirsipuuSalaSana()
        {
            Random rand = new Random();
            int index = rand.Next(0, hirsipuuSanat.Length);
            return hirsipuuSanat[index];
        }
    }
}

