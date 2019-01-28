using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("a: " + 12 + ", b: " + 45);
            Console.WriteLine(string.Format("a: {0:C}, b:{1}", 12, 45));

            Client client = new Client();

            client.Nom = "Dupont";
            client.Prenom = "Jean";

            client.Afficher();
        }
    }
}
