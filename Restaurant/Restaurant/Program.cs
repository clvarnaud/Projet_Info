using System;

namespace ProjetInfo_S2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			client arnaud;

			arnaud = new client ("CLAVERO","Arnaud","06.67.02.68.04");

			Console.WriteLine (arnaud);
			Console.ReadLine ();
			arnaud.modificationClient ();

			Console.ReadLine ();
		}
	}
}
