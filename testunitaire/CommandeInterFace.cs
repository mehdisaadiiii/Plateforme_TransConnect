using System;
using System.Collections.Generic;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class CommandeInterFace : IMoyenne //implémenter les interfaces sur les commandes
    {
        List<Commande> c1 = ListeCommande.ObtenirListeCommande();

        public CommandeInterFace()
        {
            List<Commande> c1 = ListeCommande.ObtenirListeCommande();
        }

        public float Moyenne()
        {
            int nbcom = c1.Count;
            double somme = 0;
            foreach (Commande c in c1)
            {
                somme += c.Prix;
            }
            return (float)somme / nbcom;

        }

    }
}
