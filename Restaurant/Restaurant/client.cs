using System;

namespace ProjetInfo_S2
{
	public class client
	{
		//Attributs
		private string _nom;
		private string _prenom;
		private string _telephone;


		//Constructeur
		public client (string nom, string prenom, string telephone)
		{
			_nom = nom;
			_prenom = prenom;
			_telephone = telephone;
		}

		//Accesseurs
		public string Nom
		{
			get {return _nom;}
			set {_nom = value;}
		}

		public string Prenom
		{
			get {return _prenom;}
			set {_prenom = value;}
		}

		public string Telephone
		{
			get{return _telephone;}
			set{_telephone = value;}
		}

		//Méthode ToString()
		public override string ToString ()
		{
			string txt = "";

			txt="Nom:"+this._nom+"\n"+"Prénom:"+this._prenom+"\n"+"Téléphone:"+this._telephone;
			return txt;


		}

		public void modificationClient()
		{
			int choix;
			choix=menuModification ();
			Console.WriteLine (choix);
			Console.ReadLine ();
			
		}


		public int menuModification()
		{
			int choix;
			int arret=0;
			Console.Clear (); 
			Console.WriteLine("Quel Paramètre voulez-vous changer ?");
			Console.WriteLine("1: Nom");
			Console.WriteLine("2: Prénom");
			Console.WriteLine("3: Téléphone");

			choix = 1;

			Console.SetCursorPosition (0,choix);

			while (arret != 1) {
				ConsoleKeyInfo saisie = Console.ReadKey (true);

				if (saisie.Key == ConsoleKey.DownArrow & choix == 2) {
					choix = 3;

					Console.SetCursorPosition (0, choix);

					
				} else {
					if (saisie.Key == ConsoleKey.UpArrow & choix == 2) {
						choix = 2;
						Console.SetCursorPosition (0, choix);


					} else {

						if (saisie.Key == ConsoleKey.UpArrow & choix == 1) {
							choix = 3;
						} else {
							if (saisie.Key == ConsoleKey.DownArrow & choix == 3) {
								choix = 1;
								
							} else {
								
								if (saisie.Key == ConsoleKey.Enter) {
									arret = 1;

								}
							}
						}
					}
				}
			



				
			}
				

			return choix;


		}


	}
}

