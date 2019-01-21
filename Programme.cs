namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            
            client.Nom = "Dupont";
            client.Prenom = "Jean";

            client.Afficher();

        }
    }
}