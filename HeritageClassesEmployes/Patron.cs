using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClassesEmployes
{
    class Patron : Employe
    {

        // •	Le chiffre d’affaire est commun entre les patrons.
        // •	Le patron a un salaire annuel qui est égal à x% du chiffre d'affaire : Salaire = CA*pourcentage/100

        private static double chiffreAffaire;
        private double pourcentage;

        public static double ChiffreAffaire { get { return chiffreAffaire; } set { chiffreAffaire = value; } }

        public double Pourcentage { get { return pourcentage; } set { pourcentage = value; } }

        public Patron(int matricule, string nom, string prenom, DateTime dateNaissance, double pourcentage) : base(matricule, nom, prenom, dateNaissance)
        {
            this.pourcentage = pourcentage;
        }

        public override string ToString()
        {
            return base.ToString() + " Patron. Pourcentage : " + pourcentage;
        }

        public override double GetSalaire()
        {
            return Math.Round(chiffreAffaire * pourcentage / 100) / 12;
        }
    }
}
