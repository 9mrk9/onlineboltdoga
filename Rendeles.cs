using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineboltdoga
{
    public class Rendeles
    {
        public int ID { get; set; }
        public Felhasznalo Vevo { get; set; }
        public List<Termek> RendeltTermekek { get; set; }
        public FizetesiMod FizetesiMod { get; set; }
        public DateTime RendelesIdeje { get; set; }


        public Rendeles(int id, Felhasznalo vevo, List<Termek> rendeltTermekek, FizetesiMod fizetesiMod)
        {
            ID = id;
            Vevo = vevo;
            RendeltTermekek = rendeltTermekek;
            FizetesiMod = fizetesiMod;
            RendelesIdeje = DateTime.Now;
        }
        public void RendeltTermekekListazasa()
        {
            foreach (Termek termek in RendeltTermekek)
            {
                Console.WriteLine(termek.Nev);
            }
        }
        public void RendelestElvegzett()
        {
            Vevo.RendelesHozzaadasa(this);
        }
        public void RendelésAdatainakKiirasa()
        {
            Console.WriteLine($"Rendelés ID-je: {ID}\nRendelés ideje: {RendelesIdeje}\n\nRendelt termékek:");
            RendeltTermekekListazasa();
			Console.WriteLine($"\nFizetési mód: {FizetesiMod.Megnevezes}\nRendelés ideje: {RendelesIdeje}");
        }
        public int RendelesOsszegzes()
        {
            int osszeg = 0;
            foreach (var termek in RendeltTermekek)
            {
                osszeg += termek.Ar;
            }
            Console.WriteLine($"A rendelés összesitett értéke: {osszeg}");
            return osszeg;
        }
    }
}