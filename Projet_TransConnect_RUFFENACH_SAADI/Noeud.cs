using System;
using System.Collections.Generic;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Noeud //noeud de l'organnigramme, 
    {
        public Salarie salarie; //chaque noeud contient un salarié
        public List<Noeud> enfants; //et une liste d'enfants qui sont ses subordonnés

        public Noeud(Salarie salarie)
        {
            this.salarie = salarie;
            this.enfants = new List<Noeud>();
        }

        public void AjouterEnfants(Noeud salarie)
        {
            this.enfants.Add(salarie);
        }

        public Salarie Salarie
        {
            get { return this.salarie; }
            set { this.salarie = value; }
        }

    }
}
