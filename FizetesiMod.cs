using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineboltdoga
{
	public class FizetesiMod
	{
		public int ID { get; set; }
		public string Megnevezes { get; set; }
		public string Leiras { get; set; }

		public FizetesiMod(int id, string megnevezes, string leiras)
		{
			ID = id;
			Megnevezes = megnevezes;
			Leiras = leiras;
		}
		public void FizetesiModAdatainakKiirasa()
		{
			Console.WriteLine($"ID: {ID}\nMegnevezés: {Megnevezes}\nLeírás: {Leiras}");
		}
		public void FizetesiModValasztas()
		{
			Console.WriteLine($"Fizetési mód kiválasztásra került: {Megnevezes}");
		}
		public void FizetesiModTorlese()
		{
			Console.WriteLine($"Fizetési mód törlésre került: {Megnevezes}");
		}
		public void FizetesiModModositasa(string ujLeiras)
		{
			Leiras = ujLeiras;
		}
		public void FizetesiModLetrehozas()
		{
			Console.WriteLine($"Fizetési mód létrehozva: {Megnevezes}");
		}
	}
}