using System;
namespace Tikkupelit
{
	public class LaskinPeli
	{
		public void LaskinPeliRun()
		{
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
				// Tàhàn eràn kaava

                break;	// Tilapàinen Break; otetaan pois myòhemmin
			}

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

