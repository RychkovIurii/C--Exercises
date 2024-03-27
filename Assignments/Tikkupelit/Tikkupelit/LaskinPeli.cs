using System;
using System.Data;
namespace Tikkupelit
{
	public class LaskinPeli
	{
		public void LaskinPeliRun()
		{
			LaskinPeliAivot aivot = new LaskinPeliAivot();
			int pisteet = 0;
			int era = 0;

            Console.Clear();
            Console.WriteLine("Tervetuloa LaskinPeliin!");
			while(true)
			{
				era++;
				Console.WriteLine("Erà: " + era);
                Console.WriteLine("Pisteet: " + pisteet);
				Console.WriteLine();
				string eranKaava = aivot.KaavanLuonti(); // Tàhàn eràn kaava
                Console.WriteLine("Lasku: " + eranKaava);
                string eranVastaus = aivot.LaskinKavaanVastaus(eranKaava);
				string pelajaanVastaus = LaskinInput();
				if(aivot.LaskinVastausTarkistus(eranVastaus, pelajaanVastaus) == false)
				{
					break;
				}
				pisteet++;
				Console.WriteLine("Press any key to continue");
				Console.ReadKey();
				Console.Clear();
                //	Console.WriteLine("Eran vastaus: " + eranVastaus);
			}
			Console.WriteLine("GAME OVER");
			Console.WriteLine("Sait: " + pisteet);
        }

		string LaskinInput()
		{
			while (true)
			{
				Console.WriteLine("Kirjoita vastaus");
				string vastausInput = Console.ReadLine(); // Ottaa Inputin vastaan
				if (vastausInput.Length > 0 && double.TryParse(vastausInput, out double muutettuInput))
				{
					return vastausInput;
				}
				else
				{
					Console.WriteLine("Invalid input");
				}
			}
		}
	}
}

public class LaskinPeliAivot
{
	Random rand = new Random();

	public string KaavanLuonti()
	{
		string kaavaPalautus = "";
		int kaavatyyppi = rand.Next(0, 4);
		char kaavaMerkki = '+';

		if (kaavatyyppi == 0)
		{
			kaavaMerkki = '/';
		}
		else if (kaavatyyppi == 1)
		{
            kaavaMerkki = '-';
        }
		else if (kaavatyyppi == 2)
		{
            kaavaMerkki = '*';
        }
		int numero1 = rand.Next(-50, 50);
		int numero2 = rand.Next(-50, 50);

		if (kaavaMerkki == '/')
		{
			numero2 = rand.Next(-10, 10);
		}
		if (kaavaMerkki == '/' && numero2 == 0)
        {
            numero2 = rand.Next(-10, 10);
        }
		kaavaPalautus = numero1.ToString() + " " + kaavaMerkki + " " + numero2.ToString();

        return kaavaPalautus;
	}
    public string LaskinKavaanVastaus(string lasku)
    {
		string vastausPalautus = new DataTable().Compute(lasku, null).ToString();
		return vastausPalautus;
    }

	public bool LaskinVastausTarkistus(string vastaus, string inputti)
	{
		if (vastaus == inputti)
		{
			Console.WriteLine("Oikein");
			return true;
		}
		Console.Clear();
        Console.WriteLine("Vastasit vààrin");
        Console.WriteLine("Oikea vastaus oli: " + vastaus);
		return false;
    }
}