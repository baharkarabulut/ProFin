using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFin
{
	public static class CurrentSession
	{
		public static int KullaniciID { get; set; }
		public static string KullaniciAdi { get; set; }
		public static string AdSoyad { get; set; }
		public static string Eposta { get; set; }
		public static string Rol { get; set; }

		public static void Clear()
		{
			KullaniciID = 0;
			KullaniciAdi = null;
			AdSoyad = null;
			Eposta = null;
			Rol = null;
		}
	}
}
