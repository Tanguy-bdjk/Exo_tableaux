using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] week = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"
            };
           int i = Array.IndexOf(week, "Jeudi"); // IndexOf Signale l'index de base zéro de la première occurrence d'un caractère ou d'une chaîne Unicode spécifiés dans cette instance. La méthode retourne -1 si le caractère ou la chaîne est introuvable dans cette instance.
            week[i+1] = "vendredi";
               foreach (String day in week)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine(week);
                Console.ReadKey();
        }       
    }
}