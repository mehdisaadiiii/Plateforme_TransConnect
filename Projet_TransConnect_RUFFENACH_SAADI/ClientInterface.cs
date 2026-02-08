using System;
using System.Collections.Generic;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class ClientInterface : IMoyenne //on peut appeler les interfaces dans cette classe vu qu'elle n'est pas static donc classe utile pour les statistiques
    {
        List<Client> d1 = ListeClients.ObtenirListeClients();

        public ClientInterface()
        {
            List<Client> d1 = ListeClients.ObtenirListeClients();
        }

        public void AfficherClientsParNom()
        {
            // Trier les clients par ordre alphabétique du nom
            d1.Sort((c1, c2) => c1.Nom.CompareTo(c2.Nom));

            // Afficher les clients
            foreach (var client in d1)
            {
                Console.WriteLine($"Nom: {client.Nom}, Prénom: {client.Prenom}");
            }
        }

        public void AfficherClientsParVille()
        {
            // Filtrer les clients dont la ville 
            d1.Sort((c1, c2) => c1.Ville.CompareTo(c2.Ville));

            // Afficher les clients filtrés
            foreach (var client in d1)
            {
                Console.WriteLine($"Nom: {client.Nom}, Prénom: {client.Prenom}, Ville: {client.Ville}");
            }
        }

        public void AfficherComptesDecroissant()
        {
            // Trier les clients en fonction du compte client dans l'ordre décroissant
            d1.Sort((c1, c2) => c2.CompteClient.CompareTo(c1.CompteClient));

            // Afficher les comptes clients
            foreach (var client in d1)
            {
                Console.WriteLine($"Nom: {client.Nom}, Compte Client: {client.CompteClient}");
            }
        }

        public void AfficherRapportsDecroissant()
        {
            // Trier les clients en fonction du rapport CompteClient / NbCommande dans l'ordre décroissant
            d1.Sort((c1, c2) => (c2.CompteClient / c2.NbCommande).CompareTo(c1.CompteClient / c1.NbCommande));

            // Afficher les clients avec le résultat du rapport CompteClient / NbCommande
            foreach (var client in d1)
            {
                Console.WriteLine($"Nom: {client.Nom}, Prix moyen par commande: {(client.CompteClient / client.NbCommande)}");
            }
        }

        public float Moyenne()
        {
            int nbClient = d1.Count;
            double somme = 0;
            foreach (Client c in d1)
            {
                somme += c.CompteClient;
            }
            return (float)somme / nbClient;

        }

        public double Somme()
        {
            double somme = 0;
            foreach(Client c in d1)
            {
                somme += c.CompteClient;
            }
            return somme;
        }
    }
}
