namespace ConsoleApp
{
    class Client
    {
        private int id;
        private string nom;

        public string nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string prenom 
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