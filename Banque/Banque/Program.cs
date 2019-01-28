using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque
{
    class dupont
    {
        static void Main(string[] args)
        {
            Client dupont = new Client();

            dupont.Nom = "Dupont";
            Console.WriteLine("nom = " + dupont.Nom);
        }
    }
}