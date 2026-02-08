using System;
using System.Collections.Generic;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public static class ListeClients //Obtenir la liste des clients comme pour la liste salarié en static
    {
        private static List<Client> listeClients = new List<Client>();

        public static void AjouterClient(Client Client)
        {
            listeClients.Add(Client);
        }

        public static void SupprimerClient(Client Client)
        {
            listeClients.Remove(Client);

        }

        public static List<Client> ObtenirListeClients()
        {
            return listeClients;
        }

        public static Client Find(string nom, string prenom) //trouver un client de manière précise pour la suppression
        {
            return listeClients.Find(s => s.Nom == nom && s.Prenom == prenom);
        }
    }
}