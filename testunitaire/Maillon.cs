using System;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Maillon //Reprise des TDs
    {
        int valeur;
        Maillon suivant;

        public Maillon()
        {
            this.valeur = 0;
            this.suivant = null;
        }

        public Maillon(int valeur, Maillon suivant)
        {
            this.valeur = valeur;
            this.suivant = suivant;
        }

        public int Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }

        public Maillon Suivant
        {
            get { return this.suivant; }
            set { this.suivant = value; }
        }
    }
}
