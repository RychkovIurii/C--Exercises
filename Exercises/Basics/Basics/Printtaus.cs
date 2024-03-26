using System;
namespace Basics
{
	public class Printtaus
	{
		public void SananPrittaaja(string sana1, String sana2)
		{
			string yhdistetty = sana1 + sana2;
			int yhdistettyPituus = SananPituus(yhdistetty);
			Console.WriteLine(yhdistetty);
			Console.WriteLine("Yhdistetty sanan pituus on: " + yhdistettyPituus);

			int randomLuku = RandomNum(5, 7);
			Console.WriteLine("Random luku oli: " + randomLuku);
			UserInput();
		}

		int SananPituus(string sana)    // Метод для вычисления длины строки
		{
			int palautus = sana.Length;
			return palautus;
		}

		int RandomNum(int minimi, int maximi)   // Метод для генерации случайного числа в заданном диапазоне
		{
			Random rand = new Random();
			int palautus = rand.Next(minimi, maximi);
			return palautus;
		}

		string UserInput()
		{
			Console.WriteLine("Anna sana: ");
			string palautus = Console.ReadLine();

			Console.WriteLine();
			Console.WriteLine("Kirjoitit: " + palautus);
			return palautus;
		}
	}
}
