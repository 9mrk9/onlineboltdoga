using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace onlineboltdoga
{
    public class Kosar
    {
        public List<Termek> Termekek { get; set; }

        public Kosar()
        {
            Termekek = new List<Termek>();
        }
        public void TermekHozzaadasa(Termek termek)
        {
            Termekek.Add(termek);
        }
        public void TermekTorlese(Termek termek)
        {
            Termekek.Remove(termek);
        }
        public void KosarUritese()
        {
            Termekek.Clear();
        }
        public void KosarTartalma()
        {
            foreach (Termek termek in Termekek)
            {
                Console.WriteLine(termek.Nev);
            }
        }
        public void KosarAra()
        {
            int osszeg = 0;
            foreach (Termek termek in Termekek)
            {
                osszeg += termek.Ar;
            }
            Console.WriteLine($"A kosár összértéke: {osszeg}Ft");
        }
        public void TermekMennyisegKiiras(Termek termek)
        {
            int temp = 0;
        foreach (Termek _termek in Termekek)
            {
                if (_termek == termek)
                {
                    temp++;
                }
            }
            Console.WriteLine($"{temp}db van a listában a keresett termékből.");
        }
        public void TermekMennyisegNovel(Termek termek, int mennyiseg)
        {
            for (int i = 0; i < mennyiseg; i++)
            {
                TermekHozzaadasa(termek);
            }
        }
        public void TermekMennyisegCsokken(Termek termek, int mennyiseg)
        {
            for (int i = 0; i < mennyiseg; i++)
            {
                TermekTorlese(termek);
            }
        }
    }
}
