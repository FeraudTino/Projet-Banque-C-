using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque
{
    class dupont
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("a: " + 12 + ", b: " + 45);
            Console.WriteLine(string.Format("a: {0:C}, b:{1}", 12, 46));

            Client dupont = new Client();

            dupont.Nom = "Dupont";
            dupont.Prenom = "Rudolph";
            dupont.Age = "12ans";
            dupont.Afficher();
        }
    }
}