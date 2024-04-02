using System;
namespace Tikkupelit
{

    public class TikkuStartteri
	{

        static void Main(string[] args)
		{

            string menu = "Valitse numero tai napaile nimeà" +
                            "\n1.Laskinpeli" +
                            "\n2.Hirsipuu" +
                            "\n3.Quit";


            while (true)
            {
                Console.WriteLine(menu);
                string kayttajaInput = Console.ReadLine();

                if (kayttajaInput != null)
                {
                    switch (kayttajaInput.ToLower())
                    {
                        case "1":
                        case "laskinpeli":
                            Console.Clear();
                            Console.WriteLine("Aloitetaan Laskinpeli");
                            LaskinPeli laskin = new LaskinPeli();
                            laskin.LaskinPeliRun();
                            break;
                        case "2":
                        case "hirsipuu":
                            Console.Clear();
                            Console.WriteLine("Aloitetaan Hirsipuu");
                            HirsipuuPeli hirsin = new HirsipuuPeli();
                            hirsin.HirsipuuRun();
                            break;
                        case "3":
                        case "quit":
                            Console.Clear();
                            Console.WriteLine("Quit");
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");
                            continue;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");
                }
            }
		}
	}
}

