using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_TransConnect_RUFFENACH_SAADI
{

    //cette classe représente le calcul fait à chaque étape sur un noeud du graphe avec l'algo Dijkstra

    public class Etape
    {
        Lien lien;
        int km;
        float duree;
        Noeud1 precedent;

        public Etape(int km, float duree, Noeud1 precedent, Lien lien)
        {
            this.km = km;
            this.duree = duree;
            this.precedent = precedent;
            this.lien = lien;
        }

        public Lien Lien
        {
            get { return this.lien; }
            set { this.lien = value; }
        }

        public Noeud1 Precedent
        {
            get { return this.precedent; }
            set { this.precedent = value; }
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
    }
}
