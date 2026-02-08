using System;
using System.Collections.Generic;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public static class Entreprise //Obtenir la liste des salariés, classe static pour pouvoir stocker nos données dans la console et y faire des modifications en temps réel
    { //avoir accès aux données sans avoir à instancier des objets de type salarié par exemple, pour plus de facilité et une plus simple accessibilité
        public static List<Salarie> listeSalaries = new List<Salarie>();

        public static void AjouterSalarie(Salarie salarie)
        {
            listeSalaries.Add(salarie);
        }

        public static void SupprimerSalarie(Salarie salarie)
        {
            listeSalaries.Remove(salarie);

        }

        public static List<Salarie> ObtenirListeSalaries()
        {
            return listeSalaries;
        }

        public static void AfficherLivraisonParChauffeur() 
        {
            Console.Write("Historique des commandes : ");
            foreach (Salarie s in listeSalaries)
            {
                if(s.Poste == "Chauffeur")
                {
                    Console.WriteLine("Le chaffeur " + s.Prenom + " " + s.Nom + " a effectué " + s.NbLivraison + " livraison(s).");
                }
                Console.WriteLine("\n");
                //Console.WriteLine(s.ToString());
            }
        }

        public static Salarie Find(string poste)
        {
            return listeSalaries.Find(s => s.Poste == poste);
        }

        public static Salarie Find(string nom, string prenom) //trouver un salarié de manière précise pour le licenciement
        {
            return listeSalaries.Find(s => s.Nom == nom && s.Prenom == prenom);
        }


    }
}
