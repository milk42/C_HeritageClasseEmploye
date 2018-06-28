using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClassesEmployes
{
    class Ouvrier : Employe
    {

        // •	Tous les ouvriers ont une valeur commune appelée SMIG=2500 DH
        // •	L’ouvrier a un salaire mensuel qui est : Salaire = SMIG + (Ancienneté en année)*100.
        // •	De plus, le salaire ne doit pas dépasser SMIG*2*

        private DateTime dateArrivee;
        public static int smig = 2500;

        private DateTime DateArrivee { get { return this.dateArrivee; } set { this.dateArrivee = value; } }

        public int Smig { get { return smig; } }

        public Ouvrier(int matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateArriveee) : base(matricule, nom, prenom, dateNaissance)
        {
            this.dateArrivee = dateArriveee;
        }
        public override string ToString()
        {
            return base.ToString() + " Ouvrier.";
        }

        public override double GetSalaire()
        {
            double salaire;
            int Anciennete = DateTime.Now.Year - dateArrivee.Year;
            if (dateArrivee.AddYears(Anciennete) > DateTime.Now.Date)
                Anciennete--;
            if (smig + Anciennete * 100 <= 2 * smig)
                salaire = smig + Anciennete * 100;
            else
                salaire = smig * 2;
            return salaire;
        }
    }
}
