using System;
using System.Collections.Generic;
namespace Tikkupelit
{
	public class Blackjack
	{
        PeliKortit peliKortit = new PeliKortit();
        BlackjackAivot blackjackAivot = new BlackjackAivot();
        // balckjack visualizer

        public void BlackjackRun()
        {
            Console.Clear();
            Console.WriteLine("Tervetuloa blackjackiin");
            List<PeliKortti> blackjackpakka = new List<PeliKortti>();
            peliKortit.ValmistaPakka();
            blackjackpakka = peliKortit.korttiPakka;

            // Aseta pelaaja
            List<KorttiPelaaja> pelaajat = BlackjackPelaajaAsettaja();

            bool peliOnOhi = false;
            while(peliOnOhi == false)
            {
                if (blackjackpakka.Count < 10)
                {
                    blackjackpakka.Clear();
                    blackjackpakka = peliKortit.korttiPakka;
                }
                foreach(KorttiPelaaja pelaaja in pelaajat)
                {
                    pelaaja.korttiKasi.Clear();
                    pelaaja.korttiKasi.Add(peliKortit.NostaKortti(blackjackpakka));
                    pelaaja.korttiKasi.Add(peliKortit.NostaKortti(blackjackpakka));
                }
                int pelaajaNumero = 1;
                foreach(KorttiPelaaja pelaaja in pelaajat)
                {
                    bool vuoroLoppuu = false;
                    while (vuoroLoppuu == false)
                    {
                        // Vuorojen kàsittely
                    }
                }
            }
        }
        List<KorttiPelaaja> BlackjackPelaajaAsettaja()
        {
            List<KorttiPelaaja> palautusLista = new List<KorttiPelaaja>();

            palautusLista.Add(new KorttiPelaaja()
            {
                PelaajaTyyppi = KorttiPelaajatyyppi.dealeri,
                PelaajaKomennot = { "Hit", "Stand" }
            });
            return palautusLista;
        }
    }
}

