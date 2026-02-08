using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    //cette classe représente les données pour chaque lien (km et durée entre chaque ville)

    public class Lien
    {
        Noeud1 noeudDepart;
        int km;
        float duree; //les durées seront de type 2.5 pour 2h30 par exemple (le fichier distance sera ainsi modifié)

        public Lien(int km, float duree, Noeud1 noeudDepart)
        {
            this.noeudDepart = noeudDepart;
            this.km = km;
            this.duree = duree;
        }

        public int Km
        {
            get { return this.km; }
            set { this.km = value; }
        }

        public float Duree
        {
            get { return this.duree; }
            set { this.duree = value; }
        }

        public Noeud1 NoeudDepart
        {
            get { return this.noeudDepart; }
            set { this.noeudDepart = value; }
        }

        public Noeud1 GetNoeudDepart()
        {
            return this.noeudDepart;
        }
    }
}
