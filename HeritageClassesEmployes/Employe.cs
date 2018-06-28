using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClassesEmployes
{
    abstract class Employe
    {
        private int matricule;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public int Matricule { get { return this.matricule; } set { matricule = value; } }
        public string Nom { get { return this.nom; } set { nom = value; } }
        public string Prenom { get { return this.prenom; } set { prenom = value; } }
        public DateTime DateNaissance { get { return this.dateNaissance; } set { dateNaissance = value; } }

        public Employe(int matricule, string nom, string prenom, DateTime dateNaissance)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return "Matricule: " + matricule + " Nom: " + nom + " Prénom: " + prenom + "Date de naissance: " + dateNaissance.ToShortDateString() + "Grade : ";
        }

        public abstract double GetSalaire();


    }
}
