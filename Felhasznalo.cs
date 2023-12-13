using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineboltdoga
{
	public class Felhasznalo
	{
		public int ID { get; set; }
		public string Nev { get; set; }
		public string Email { get; set; }
		public Kosar Kosar { get; set; }
		public List<Rendeles> Rendeleseim { get; set; }

		public Felhasznalo(int id, string nev, string email)
		{
			ID = id;
			Nev = nev;
			Email = email;
			Kosar = new Kosar();
			Rendeleseim = new List<Rendeles>();
		}
		public void KosarTartalma()
		{
			Kosar.KosarTartalma();
		}
		public void RendeleseimListazasa()
		{
			foreach (var rendeles in Rendeleseim)
			{
				rendeles.RendelésAdatainakKiirasa();
			}
		}
		public void EmailKuldes(string uzenet)
		{
			Console.WriteLine($"Az e-mail elküldve a felhasználónak: {Email}, üzenet: {uzenet}");
		}
		public void ProfilAdatainakKiirasa()
		{
			Console.WriteLine($"Felhasználó ID-je: {ID}\nFelhasználó neve: {Nev}\nFelhasználó e-mail címe: {Email}");
		}
		public void RendelesekOsszegezes()
		{
			int osszeg = 0;
			foreach (var rendeles in Rendeleseim)
			{
				osszeg += rendeles.RendelesOsszegzes();
			}
			Console.WriteLine($"A felhasználó rendeléseinek teljes összege: {osszeg}");
		}
		public void RendelesHozzaadasa(Rendeles rendeles)
		{
			Rendeleseim.Add(rendeles);
		}
	}
}