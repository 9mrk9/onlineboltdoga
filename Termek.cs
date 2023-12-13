using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineboltdoga
{
	public class Termek
	{
		public int ID { get; set; }
		public string Nev { get; set; }
		public int Ar { get; set; }
		public int Raktaron { get; set; }

		public Termek(int id, string nev, int ar, int raktaron)
		{
			ID = id;
			Nev = nev;
			Ar = ar;
			Raktaron = raktaron;
		}
		public void RaktarFrissites(int mennyiseg)
		{
			Raktaron = mennyiseg;
		}
		public void ArBeallitas(int ujAr)
		{
			Ar = ujAr;
		}
		public void TermekRendelese(int mennyiseg)
		{
			if (Raktaron >= mennyiseg)
			{
				Raktaron -= mennyiseg;
			}
		}
		public void TermekAdatainakKiirasa()
		{
			Console.WriteLine($"A termék ID-je: {ID}\nA termék neve: {Nev}\nA termék ára: {Ar}\nA termékből mennyi van raktáron: {Raktaron}");
		}
		public void TermekAraNovel(int szazalek)
		{
			Ar = Ar * (szazalek / 100 + 1);
		}
		public void TermekArCsokken(int szazalek)
		{
			Ar = Ar * (1 - szazalek / 100);
		}
		public void TermekAraVisszaallitas(int alapAr)
		{
			Ar = alapAr;
		}
		public void TermekAraKiiras()
		{
			Console.WriteLine($"A termék aktuális ára: {Ar}");
		}
	}
}