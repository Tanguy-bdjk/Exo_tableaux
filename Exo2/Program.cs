using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] jours = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Console.WriteLine(jours[1]); // affiche Mardi
            Console.WriteLine(jours[4]); // affiche Jeudi
            Console.ReadKey();
        }
    }
}
