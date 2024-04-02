using System;
namespace Tikkupelit
{
	public class HirsipuuPeli
	{
		bool peliOnPaalla = true;
		int vaaratYritykset = 0;
		string vastausSana = "";
		List<char> kaytetytKirjaimet = new List<char>();

		HirsipuuTekstit hirsipuuTekstit = new HirsipuuTekstit();

		public void HirsipuuRun()
		{
			hirsipuuTekstit.HirsipuuAsetus();   //Asetetaan pelin tilanteet listalle
			vastausSana = hirsipuuTekstit.HirsipuuSalaSana(); //Asetetaan pelin vastaus sana

			Console.WriteLine("Tervetuloa hirsipuuhun");
			Console.WriteLine("Paina mità tahansa nàppàintà aloittaaksesi");
			Console.ReadKey(); //Odottaa kunnes kàyttàjà painaa jotain nappia
			Console.Clear();


			while (peliOnPaalla == true)
			{
				hirsipuuTekstit.HirsipuuPiirtaja(vaaratYritykset); // Pirtàà pelin nykyisen tilanteen
				peliOnPaalla = PeliOhiTarkistus(hirsipuuTekstit.hirsipuuTilanteet);
				if (peliOnPaalla == false)
				{
					break;
				}
				// Tàhàn tulee kirjainten tulostus
				KirjanPrinttaja();
				HirsipuuInputs();
			}
		}

		void HirsipuuInputs()
		{
			Console.WriteLine("Arvaa kirjain");
			char hirsiInput = Console.ReadKey().KeyChar;
			Console.Clear();

			if (Char.IsLetter(hirsiInput))
			{
				hirsiInput = Char.ToLower(hirsiInput);
				if (kaytetytKirjaimet.Contains(hirsiInput))
				{
					Console.WriteLine("Kirjain " + hirsiInput + " on jo kàytetty");
				}
				else
				{
					kaytetytKirjaimet.Add(hirsiInput);
					// Tàhàn tulee kirjain tarkistus
					if (KirjainTarkistus(hirsiInput) == false)
					{
						vaaratYritykset++;
					}
				}
			}
			else
				Console.WriteLine("Invalid input");
		}

		bool KirjainTarkistus(char kirjain)
		{
			if (vastausSana.Contains(kirjain)) //Onko vastaus sanassa annettu kirjain
			{
				return true;
			}
			return false;
		}

		bool PeliOhiTarkistus(List<string> peliTilanteet)
		{
			// Jo ollaan menty yritys rajan yli
			if(vaaratYritykset >= peliTilanteet.Count - 1)
			{
				Console.WriteLine("GAME OVER YOU LOSE");
				Console.WriteLine("Oikea vastaus oli: " + vastausSana);
				Console.WriteLine();
                Console.WriteLine("Paina nàppàintà jatkaaksesi");
				Console.ReadKey();
				return false;
            }

			// lòytyykò kaikki vastaus sanan kirjaimet kàytetyistà kirjaimista
			foreach (char c in vastausSana)
			{
				if(!kaytetytKirjaimet.Contains(c))
				{
					return true;
				}
			}

			Console.WriteLine("GAME OVER, YOU WIN");
            Console.WriteLine("Paina nàppàintà jatkaaksesi");
            Console.ReadKey();
            return false;
        }

		void KirjanPrinttaja()
		{
			Console.Write("Vastaus sana: ");
			for (int i=0; i < vastausSana.Length; i++)
			{
				if (kaytetytKirjaimet.Count == 0)
				{
					Console.Write("_ ");
					continue;
				}
				bool cheat = true;
				foreach (char c in kaytetytKirjaimet)
				{
					if (Char.ToLower(c) == vastausSana[i])
					{
						Console.Write(vastausSana[i] + " ");
						cheat = false;
						break;
					}
				}
				if (cheat == true)
				{
					Console.Write("_ ");
				}
			}
			Console.WriteLine();
			Console.Write("Kàytrtyt kirjaimet: ");
            if (kaytetytKirjaimet.Count > 0)
            {
                foreach (char c in kaytetytKirjaimet)
				{
					Console.Write(c + " ");
				}
            }
			Console.WriteLine();
        }
	}
}
