using System;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Arbre
    {
        Noeud racine;

        public Arbre(Salarie salarie)
        {
            racine = new Noeud(salarie); //racine de l'arbre pour nous : le PDG
        }

        public void AjouterSousDirecteur(Salarie superieur, Salarie inferieur) //chaque salarié de l'entreprise doit être affilié à un supérieur pour être ajouté à l'orga, et donc pour être dans la bonne branche de l'arbre
        {
            var noeudSuperieur = RechercherNoeud(superieur, racine);
            Noeud inferieur1 = new Noeud(inferieur);
            if(noeudSuperieur != null)
            {
                noeudSuperieur.AjouterEnfants(inferieur1);
            }
            else
            {
                Console.WriteLine("Le supérieur spécifié n'existe pas dans l'arbre.");
            }
        }

        public Noeud RechercherNoeud(Salarie salarie, Noeud noeud)
        {
            if (noeud.Salarie == salarie)
            {
                return noeud;
            }

            foreach (var enfant in noeud.enfants)
            {
                var resultat = RechercherNoeud(salarie, enfant);
                if (resultat != null)
                {
                    return resultat;
                }
            }

            return null;
        }

        public void AfficherOrga()
        {
            Console.WriteLine("Organigramme de l'entreprise : \n \n");
            AfficherNoeud(racine, 0); //on affiche chaque noeud à partir de la racine et on commence au niveau 0, qui correspond au niveau du PDG
        }

        public void AfficherNoeud(Noeud noeud, int niveau) //affichage de chaque niveau de l'orga
        {
            Console.WriteLine(new string(' ', niveau * 4) + "|-- " + noeud.Salarie.Prenom + " " + noeud.Salarie.Nom + " (" + noeud.Salarie.Poste + ")");
            foreach (var enfant in noeud.enfants)
            {
                AfficherNoeud(enfant, niveau + 1);
            }
        }

        public void SupprimerNoeud(Salarie salarie) //avant de supprimer un noeud, on doit supprimer tous ses descendants, qui correspondra ici à tous les subordonnés d'un salarié
        {
            SupprimerNoeudEtSesEnfants(racine, salarie);
        }

        public bool SupprimerNoeudEtSesEnfants(Noeud noeud, Salarie salarie)
        {
            bool salarieTrouve = false;

            // Recherche le salarié dans les enfants du noeud
            foreach (var enfant in noeud.enfants)
            {
                if (enfant.Salarie == salarie)
                {
                    noeud.enfants.Remove(enfant);
                    return true;
                }
                else
                {
                    // Recherche récursive dans les enfants de l'enfant actuel
                    salarieTrouve = SupprimerNoeudEtSesEnfants(enfant, salarie);

                    // Si le salarié est trouvé dans les enfants de l'enfant actuel, on le supprime
                    if (salarieTrouve)
                    {
                        return true;
                    }
                }
            }

            return salarieTrouve;
        } //supprimer tous les descendants du noeud

    }
}
