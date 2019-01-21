namespace ConsoleApp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Client dupont = new Client();

            dupont.Nom = "Dupont";
            ConsoleApp.WriteLine("nom = " + dupont.Nom);
        }
    }
}