using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    //cette classe représente la définition du noeud
    public class Noeud1
    {
        string symbole; //nom de la ville
        List<Lien> adjacents; //graphe bidirectionnel donc simplement une liste d'adjacents, pas besoin de deux listes
        bool traite = false;
        int distance;
        Noeud1 precedent;
        List<string> listArrivant; // checker les arrivants à un noeud (les villes arrivant à un noeud)

        public Noeud1(string symbole)
        {
            this.symbole = symbole;
            adjacents = new List<Lien>();
            distance = int.MaxValue; //noeud infini pour l'algorithme de Dijkstra, tant qu'il n'a pas été parcouru
            precedent = null; //Précédent initialisé à null au début
            listArrivant = new List<string>();
        }

        public string Symbole
        {
            get { return this.symbole; }
            set { this.symbole = value; }
        }

        public void AjouterLien(Lien lien)
        {
            adjacents.Add(lien);
        }

        public List<Lien> GetAdjacents()
        {
            return adjacents;
        }

        public void AjouterArrivant(int km, float duree, Noeud1 arrivee)
        {
            this.adjacents.Add(new Lien(km, duree, arrivee)); //ajouter un nouveau lien vers un noeud adjacent à partir du noeud actuel
            listArrivant.Add(arrivee.symbole);
        }

        public bool EstArrivant(Noeud1 noeud)
        {
            return listArrivant.Contains(noeud.symbole); //vérifier si un noeud est arrivant de nôtre noeud
        }

        public bool Traite
        {
            get { return this.traite; }
            set { this.traite = value; }
        }

        public int Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public Noeud1 Precedent
        {
            get { return this.precedent; }
            set { this.precedent = value; }
        }


    }
}
