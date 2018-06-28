using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClassesEmployes
{
    class Program
    {
        static void Main(string[] args)
        {

            Ouvrier ouvrier = new Ouvrier(1, "Nom1", "Prenom1", new DateTime(1980, 2, 3), new DateTime(2000, 4, 5));
            Console.Out.WriteLine(ouvrier);
            Console.Out.WriteLine("Salaire de l'employé: " + ouvrier.GetSalaire());
            Console.Out.WriteLine("***********************************");

            Cadre cadre = new Cadre(2, "Nom2", "Prenom2", new DateTime(1986, 4, 3), 3);
            Console.Out.WriteLine(cadre);
            Console.Out.WriteLine("Le salaire du cadre est: " + cadre.GetSalaire());
            Console.Out.WriteLine("***********************************");

            Patron.ChiffreAffaire = 17000000;
            Patron patron = new Patron(3, "Nom3", "Prenom3", new DateTime(1970, 6, 6), 3);
            Console.Out.WriteLine(patron);
            Console.Out.WriteLine("Le salaire du patron est: " + patron.GetSalaire());

            Console.ReadKey();
        }
    }
}
