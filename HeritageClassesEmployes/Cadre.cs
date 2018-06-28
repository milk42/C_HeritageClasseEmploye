using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClassesEmployes
{
    class Cadre : Employe
    {

        // •	Le cadre a un salaire qui dépend de son indice : 
        //        o	1 : salaire mensuel 13000 DH
        //        o	2 : salaire mensuel 15000 DH
        //        o	3 : salaire mensuel 17000 DH
        //        o	4 : salaire mensuel 20000 DH
        private int indice;

        public int Indice {  get { return this.indice; } }

        public Cadre(int matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
        {
            this.indice = indice;
        }

        public override string ToString()
        {
            return base.ToString() + " Cadre. Indice : " + indice;
        }

        public override double GetSalaire()
        {
            switch (indice)
            {
                case(1):
                    indice = 13000;
                    break;
                case (2):
                    indice = 15000;
                    break;
                case (3):
                    indice = 17000;
                    break;
                case (4):
                    indice = 20000;
                    break;
                default:
                    indice = 13000;
                    break;
            }
            return indice;
        }
    }
}
