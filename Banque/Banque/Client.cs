using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque
{
    class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string age;

        public string Nom
        {
            get
            { return nom; }
            set
            { nom = value; }
        }
        public string Prenom
        {
            get
            { return prenom; }
            set
            { prenom = value; }
        }
        public string Age
        {
            get
            { return age; }
            set
            { age = value; }
        }

        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + ", prénom: " + prenom + ", Âge: " + age);
        }
    }
}