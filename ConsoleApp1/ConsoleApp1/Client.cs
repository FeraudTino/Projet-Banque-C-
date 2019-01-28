using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client
    {
        private int id;
        private string nom;
        private string prenom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom 
        {
            get { return prenom; }
            set { prenom = value; }    
        }
        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + ", prénom: " + prenom);
        }
    }
}