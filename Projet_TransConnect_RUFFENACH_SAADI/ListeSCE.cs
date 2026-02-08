using System;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class ListeSCE
    {
        private Maillon tete;

        public ListeSCE()
        {
            this.tete = null;
        }

        public Maillon Tete
        {
            get { return this.tete; }
            set { this.tete = value; }
        }

        // Méthode pour ajouter un maillon à la liste
        public void Ajouter(int valeur)
        {
            Maillon nouveauMaillon = new Maillon(valeur, this.tete);
            this.tete = nouveauMaillon;
        }

        // implémentation du tri à bulles pour Sort, méthode qui consiste à trier notre liste de Maillons
        public void Sort()
        {
            if (this.tete == null || this.tete.Suivant == null)
                return;

            bool test = false;
            do
            {
                Maillon actuel = this.tete;
                Maillon precedent = null;
                Maillon suivant = this.tete.Suivant;

                while (suivant != null)
                {
                    if (actuel.Valeur > suivant.Valeur)
                    {
                        test = true; //on permute nos maillons
                        if (precedent != null)
                        {
                            Maillon temp = suivant.Suivant;
                            precedent.Suivant = suivant;
                            suivant.Suivant = actuel;
                            actuel.Suivant = temp;
                        }
                        else
                        {
                            Maillon temp = suivant.Suivant;
                            this.tete = suivant;
                            suivant.Suivant = actuel;
                            actuel.Suivant = temp;
                        }

                        precedent = suivant;
                        suivant = actuel.Suivant;
                    }
                    else
                    {
                        precedent = actuel;
                        actuel = suivant;
                        suivant = suivant.Suivant;//parcourir toute la liste
                    }
                }
            } while (test);
        }

        // Méthode FindAll par rapport à une certaine valeur, ici un entier, puisque nos Maillons sont des entiers
        public ListeSCE FindAll(int valeur)
        {
            ListeSCE listeResultat = new ListeSCE();
            Maillon actuel = this.tete;

            while (actuel != null)
            {
                if (actuel.Valeur == valeur)
                {
                    listeResultat.Ajouter(actuel.Valeur);
                }
                actuel = actuel.Suivant;
            }

            return listeResultat;
        }

        // Affichage du résultat de la méthode précédente
        public void Afficher()
        {
            Maillon actuel = this.tete;
            while (actuel != null)
            {
                Console.Write(actuel.Valeur + " -> ");
                actuel = actuel.Suivant;
            }
            Console.WriteLine("null");
        }
    }
}
