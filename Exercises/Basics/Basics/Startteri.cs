using System;

namespace Basics
{
    public class Startteri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Muuttujat muu1 = new Muuttujat();
            Muuttujat muu2 = new Muuttujat();
            Muuttujat muu3 = new Muuttujat();

            muu1.numero = 5;
            muu2.numero = 7;
            muu3.numero = muu1.numero + muu2.numero;

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("numero 1: " + muu1.numero);
            Console.WriteLine("numero 2: " + muu2.numero);
            Console.WriteLine("numero 3: " + muu3.numero);

            Printtaus pr = new Printtaus();
            pr.SananPrittaaja("Haarukka", muu1.sana);
        }
    }
}

public class Muuttujat
{
    public int numero = 500;            // tasaluvut
    public bool kytkin = false;         //true tai false
    public string sana = "moi mita";    // tekstià
    public char merkki = 'x';           // yksittàisià merkkejà
    public float luku = 12.0012F;       // desimaali luvut
    public double luku2 = 12.443D;       // desimaali luvut
    public long myNum = 15000000000L;
}