using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {   // Recuperer les Infos. enum.GetNames (typeof(week)) = > renvoi un tableau d'ou l'utilisation du foreach
            String[] week = Enum.GetNames(typeof(Week));
            // Afficher le contenu (jours) de week
            foreach (String day in week)
            {
                Console.WriteLine(day);
            }
            // Afficher une valeur de l'enumeration
            Console.WriteLine("la quatrieme valeur de l'énumeration est : " + week[4]);
            
            Console.ReadKey();
        }
    }
}
// foreach(string day in Enum.GetNames(typeof(Week)))
//   {
//       Console.writeLine(day);
//   }
//       Console.WriteLine(Enum.GetName(typeof(Week),4));
