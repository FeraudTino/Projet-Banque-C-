﻿using System;

namespace ProjetBanque{

	public class Application
	{
		public void fonctionPrincipale ()
		{
			creerClient();

		}

		Client creerClient()
		{
			Client client = new Client();
			
			Console.Write("Saisir le nom de famille du client : ");
			client.nom = Console.ReadLine();

			Console.Write("Saisir le prénom du client : ");
			client.prenom = Console.ReadLine();

			Console.Write("Saisir la date de naissance du client : ");
			client.DateNaissance = Console.Readline();

			Console.WriteLine("ntm");
		}

		Banque truc2()
		{


		}

		Compte truc3()
		{


		}



	}
}
