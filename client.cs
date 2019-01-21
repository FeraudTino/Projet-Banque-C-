namespace ConsoleApp
{
    class Client
    {
        private int id;
        private string nom;

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
            ConsoleApp.WriteLine("nom: " + nom + ", prénom: " + prenom);
        }
    }
}