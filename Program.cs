using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineboltdoga
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teszteljük a Termek osztályt
            Console.WriteLine("Termek osztály tesztelése:\n");

            //Termék létrehozása és adatainak kiírása
            Termek termek01 = new Termek(1, "Telefon", 1000, 100);
            Termek termek02 = new Termek(2, "Monitor", 650, 150);
            Termek termek03 = new Termek(3, "Billentyűzet", 500, 200);

            Console.WriteLine("A létrehozott termékek adatainak kiírása:\n");
            termek01.TermekAdatainakKiirasa();
			Console.WriteLine();
            termek02.TermekAdatainakKiirasa();
			Console.WriteLine();
            termek03.TermekAdatainakKiirasa();

            //Raktárfrissítés és rendelés
            Console.WriteLine("\nRaktáron lévő termékek státuszának változtatása és rendelés:");
            termek01.RaktarFrissites(80);
			Console.WriteLine();
            termek01.TermekAdatainakKiirasa();
			Console.WriteLine();
            termek01.TermekRendelese(3);
            termek01.TermekAdatainakKiirasa();
            Console.WriteLine();
            
            // Teszteljük a Kosar osztályt
            Console.WriteLine("Kosár osztály tesztelése:\n");
            //Termék hozzáadása és törlése a kosárból
            Kosar kosar = new Kosar();
            kosar.TermekHozzaadasa(termek01);
            kosar.TermekHozzaadasa(termek02);
            kosar.TermekHozzaadasa(termek03);

            Console.WriteLine("Termékek a kosárban:");
            kosar.KosarTartalma();
            kosar.TermekTorlese(termek02);
            Console.WriteLine("\nTermék törlése után a kosár:");
            kosar.KosarTartalma();
            Console.WriteLine();
            
            //Kosár összértékének ellenőrzése
            Console.WriteLine("Kosár összértékének ellenőrzése:");
            kosar.KosarAra();
            Console.WriteLine();
            
            //Teszteljük a Felhasznalo osztályt
            Console.WriteLine("Felhasznalo osztály tesztelése:\n");

            //Felhasználó létrehozása és profiladatainak megjelenítése
            Felhasznalo felhasznalo01 = new Felhasznalo(1, "James Smith", "james.smith@gmail.com");
            Felhasznalo felhasznalo02 = new Felhasznalo(2, "Mark Smith", "mark.smith@gmail.com");
            FizetesiMod bankkartya = new FizetesiMod(1, "bankkártya", "Kártyával lévő vásárlások esetén");
            Rendeles rendeles01 = new Rendeles(1, felhasznalo01, new List<Termek>() { termek01, termek02 }, bankkartya);

            Console.WriteLine("Profiladatok megjelenítése:");
            felhasznalo01.ProfilAdatainakKiirasa();
			Console.WriteLine();
            felhasznalo02.ProfilAdatainakKiirasa();
            Console.WriteLine();

            //Felhasználó rendeléseinek ellenőrzése
            Console.WriteLine("Felhasználó rendeléseinek ellenőrzése:\n");
            felhasznalo01.Kosar.TermekHozzaadasa(termek01);
            felhasznalo01.Kosar.TermekHozzaadasa(termek02);
            rendeles01.RendelestElvegzett();
            felhasznalo01.RendeleseimListazasa();
            Console.WriteLine();
            
            //Teszteljük a FizetesiMod osztályt
            Console.WriteLine("FizetesiMod osztály tesztelése:\n");

            //Fizetési módok kezelése (1 fizetési mód már létre lett hozva)
            FizetesiMod utanvet = new FizetesiMod(2, "Utánvét", "Készpénzzel fizetendő, a futár veszi át");

            Console.WriteLine("Fizetési módok kezelése:");
            bankkartya.FizetesiModAdatainakKiirasa();
			Console.WriteLine();
            utanvet.FizetesiModAdatainakKiirasa();
			Console.WriteLine();
            bankkartya.FizetesiModTorlese();
            Console.WriteLine();
            utanvet.FizetesiModAdatainakKiirasa();
            Console.WriteLine();

            //Új fizetési mód hozzáadása
            Console.WriteLine("Új fizetési mód hozzáadása:\n");
            bankkartya.FizetesiModLetrehozas();
            bankkartya.FizetesiModAdatainakKiirasa();
            
            Console.ReadKey();
        }
    }
}
