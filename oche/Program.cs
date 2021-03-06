﻿using System;

namespace oche
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			// Per llegir els arguments de l'execució
			// oche nom

			if (args.Length == 0)
			{
				Console.WriteLine("Has de posar el teu nom!!");
				Console.WriteLine("Format: oche nom");


			}
			else
			{
				//string nom = args[0];
				var nom = args[0];
				var hora = DateTime.Now.Hour;
				string missatge = null;
				if (hora >= 6 && hora < 12)
					missatge = "Buenos dias " + nom;
				else if (hora >= 12 && hora < 20)
					missatge = "Buenos tardes " + nom;
				else
					missatge = "Buenos noches " + nom;
				Console.WriteLine(missatge);
				bool bucle=true;
				do
				{
					var entrada = Console.ReadLine();
					if (entrada.Equals("Stop!"))
						bucle = false;
					else
					{
						string sortida = invertirString(entrada);
						//string sortida = invertirString2(entrada);
						Console.WriteLine(sortida);
						if (entrada.Equals(sortida))
							Console.WriteLine("Bonica paraula!!");
						    

					}

				} while (bucle);
			}
		}



		//Mètode per invertir un string molt poc refinat
		//però molt evident. Proposeu millores ;)

		private static string invertirString(string value)
		{
			string cadena = null;
			int t = value.Length;
			for (int i = t - 1; i >= 0; i--)
			{
				cadena = cadena + value.Substring(i, 1);
			}

			return cadena;
		}



		//Mètode usant el mètode Reverse associats a arrays
		private static string invertirString2(string value)

		{
			char[] charArray = value.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

	}
}
	