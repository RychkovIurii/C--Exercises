using System;
namespace Basics1
{
	public enum KspKadet
	{
		Kivi = 0,
		Sakset = 1,
		Paperi = 2
	}

	public class KiviSaksetPaperi
	{
		Random rand = new Random();
		int voitot = 0;
		int tappiot = 0;
		int tasapelit = 0;
		int era = 1;

		public void KspPeli()
		{
			Console.WriteLine("Tervetuloa KSP peliin");
			Console.WriteLine();
			while (true)
			{
				Console.WriteLine("Erà: " + era);
				Console.WriteLine("Kivi = \"k\", Sakset = \"s\", Paperi = \"p\" ja Lopeta peli = \"q\"");
                int vastustajanValinta = rand.Next(0, 3);

				KspKadet vastustajanKasi = KspKadet.Kivi + vastustajanValinta;

				char kayttajaInput = Console.ReadKey().KeyChar;

				KspKadet pelaajanKasi = KspKadet.Kivi;

				switch (kayttajaInput)
				{
					case 'k':
                        pelaajanKasi = KspKadet.Kivi;
                        break;
                    case 's':
						pelaajanKasi = KspKadet.Sakset;
                        break;
                    case 'p':
						pelaajanKasi = KspKadet.Paperi;
                        break;
                    case 'q':
						Console.Clear();
                        TilanteenTulostus();
                        Console.WriteLine("Lopetetaan KSP peli");
						return;
                    default:
						Console.Clear();
                        Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");
                        continue;
				}

                //Console.Clear();
				string tilanne = "Pelaaja laittoi: " + pelaajanKasi + "\tVastustaja laittoi: " + vastustajanKasi;
                Console.WriteLine();
                Console.WriteLine(tilanne);
				
				string voittaja;
				if (pelaajanKasi == vastustajanKasi)
				{
					voittaja = "Tasapeli";
					tasapelit++;
				}
				else if ((pelaajanKasi == KspKadet.Sakset && vastustajanKasi == KspKadet.Paperi) ||
                        (pelaajanKasi == KspKadet.Paperi && vastustajanKasi == KspKadet.Kivi) ||
                        (pelaajanKasi == KspKadet.Kivi && vastustajanKasi == KspKadet.Sakset))
				{
					voitot++;
					voittaja = "Pelaaja voitti";
				}
				else
				{
					tappiot++;
					voittaja = "Vastustaja voitti";
				}
				Console.WriteLine(voittaja);
				era++;
			}
		}
        void TilanteenTulostus()
        {
            string voittoTilanne = "Voitot: " + voitot + "\tTappiot: " + tappiot + "\tTasapelit: " + tasapelit;
            Console.WriteLine(voittoTilanne);
        }
    }
}

