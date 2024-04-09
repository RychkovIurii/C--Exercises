using System;
namespace Tikkupelit
{
	public class PeliKortit
    {
        public List<PeliKortti> korttiPakka = new List<PeliKortti>();

        public void ValmistaPakka()
        {
            KorttiMaa referenssiMaa = 0;
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    string korttiNimi = "";
                    switch (j)
                    {
                        case 0:
                            korttiNimi = "A";
                            break;
                        case 10:
                            korttiNimi = "J";
                            break;
                        case 11:
                            korttiNimi = "Q";
                            break;
                        case 12:
                            korttiNimi = "K";
                            break;
                        default:
                            korttiNimi = (j + 1).ToString();
                            break;
                    }
                    // ♠ ♥ ♦ ♣
                    switch (referenssiMaa)
                    {
                        case KorttiMaa.Risti:
                            korttiNimi = korttiNimi + "♣";
                            break;
                        case KorttiMaa.Pata:
                            korttiNimi = korttiNimi + "♠";
                            break;
                        case KorttiMaa.Ruutu:
                            korttiNimi = korttiNimi + "♦";
                            break;
                        case KorttiMaa.Hertta:
                            korttiNimi = korttiNimi + "♥";
                            break;
                    }
                    korttiPakka.Add(new PeliKortti() { KorttiNumero = j + 1, Maa = referenssiMaa, KorttiNimi = korttiNimi });
                }
                referenssiMaa++;
            }
        }

        public void KorttiDemo()
        {
            ValmistaPakka();

            foreach(PeliKortti kortti in korttiPakka)
            {
                kortti.ShowCard(true);
            }
        }

        //Palautta listalta yhden stunnaisen esineen ja poistaa sen listalta
        public PeliKortti NostaKortti(List<PeliKortti> pakka)
        {
            Random rand = new Random();
            PeliKortti palautusKortti = new PeliKortti();
            int korttiIndex = rand.Next(pakka.Count);
            palautusKortti = pakka[korttiIndex];
            pakka.RemoveAt(korttiIndex);
            return palautusKortti;
        }

        // Sekitta Listan sisàllòn jàrjestyksen
        public List<PeliKortti> SekoitettuPakka(List<PeliKortti> pakka)
        {
            Random rand = new Random();
            pakka = pakka.OrderBy(a => rand.Next()).ToList();
            return pakka;
        }

        public List<PeliKortti> NostaYlin(List<PeliKortti> pakka)
        {
            //Lukaa metodi joka palauttaa listan viimeisen kortin ja poistaa sen listalta
            PeliKortti palautusKortti = new PeliKortti();
            palautusKortti = new PeliKortti();
            palautusKortti = pakka.Last();
            pakka.RemoveAt(pakka.Count - 1);
            return palautusKortti;
        }
    }

    public enum KorttiMaa
    {
        Risti = 0,
        Pata = 1,
        Hertta = 2,
        Ruutu = 3
    }
    public class PeliKortti
    {
        public int KorttiNumero {  get; set; }
        public KorttiMaa Maa { get; set; }
        public string KorttiNimi { get; set; }

        public void ShowCard()
        {
            Console.Write("[" + KorttiNimi + "]");
        }
        public void ShowCard(bool rivitys)
        {
            Console.Write("[" + KorttiNimi + "]");
            if (rivitys == true)
            {
                Console.WriteLine();
            }
        }
    }

    public enum KorttiPelaajatyyppi
    {
        pelaja,
        dealeri,
        vastustaja,
        poyta
    }

    public class KorttiPelaaja
    {
        public List<PeliKortti> korttiKasi = new List<PeliKortti>();

        public KorttiPelaajatyyppi Pelaajatyyppi { get; set; }
        public List<string> PelaajaKomennot { get; set } = new List<string>();

        public int PelaajanChipit { get; set }
        public int pelaajanPanos = 0;

        public void NaytaKasi()
        {
            foreach(PeliKortti kortti in korttiKasi)
            {
                kortti.ShowCard();
            }
            Console.WriteLine();
        }

    }
}

