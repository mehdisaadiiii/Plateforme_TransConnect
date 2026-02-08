using System;
using System.Collections.Generic;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public static class ListeCommande //gestion similaire à la gestion des salariés et des clients, cette classe nous permet d'avoir accès à l'ensemble des commandes passées dans l'app
    {
        public static List<Commande> listeCommandes = new List<Commande>();

        public static void AjouterCommande(Commande commande)
        {
            listeCommandes.Add(commande);
        }

        public static void SupprimerCommande(Commande commande)
        {
            listeCommandes.Remove(commande);

        }

        public static List<Commande> ObtenirListeCommande()
        {
            return listeCommandes;
        }

        public static void AfficherCommande()
        {
            Console.Write("Historique des commandes : ");
            foreach (Commande c in listeCommandes)
            {
                Console.WriteLine("\n");
                Console.WriteLine(c.ToString());
            }

            Console.Write("Affichage par prix et N°Identification : ");
            foreach (Commande c in listeCommandes)
            {
                Console.WriteLine("\n");
                c.AfficherPrixCommande();
            }
        }

        public static Commande Find(int id) //trouver une commande de manière précise pour l'affichage de l'itinéraire
        {
            return listeCommandes.Find(s => s.IdCom == id);
        }

        public static void AfficherCommandePourUnClient(Client a)
        {
            foreach (Commande s in listeCommandes)
            {
                if (s.A == a)
                {
                    Console.WriteLine("Voici vos commandes passées : ");
                    Console.WriteLine(s.ToString());
                }
                Console.WriteLine("\n");
            }
        }

        public static void TestFindAll(DateTime dateDebut, DateTime dateFin)
        {
            List<Commande> c1 = listeCommandes.FindAll(c => c.Date >= dateDebut && c.Date <= dateFin);

            Console.WriteLine($"Commandes passées entre {dateDebut.ToShortDateString()} et {dateFin.ToShortDateString()} :");
            c1.ForEach(c => Console.WriteLine(c.ToString()));
        }

        public static void TestFindAll1(Salarie ss)
        {
            List<Commande> liste1 = listeCommandes.FindAll(x => x.Chauffeur == ss);
            Console.WriteLine("Voici la liste des commandes à effectuer " + ss.Nom + " " + ss.Prenom + " :");
            liste1.ForEach(x => Console.WriteLine("Livraison à effectuer entre : " + x.VilleD + " -> " + x.VilleA + " pour le : " + x.Date.ToShortDateString() + " ."));
            Console.WriteLine("\nBon courage !");
        }

    }
}
