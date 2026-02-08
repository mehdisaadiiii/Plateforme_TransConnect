using System;
using System.Collections.Generic;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Client : Personne
    {
        string statut;
        double compteClient;
        int nbCommande;
        DateTime dateCreationCompte;
        string ville;

        public Client(int id_ss, string nom, string prenom, DateTime dateNaissance, string ville, string adresse, string mail, string numeroTel, string statut, double compteClient, int nbCommande, DateTime dateCreationCompte) : base(id_ss, nom, prenom, dateNaissance, adresse, mail, numeroTel)
        {
            this.statut = statut;
            this.compteClient = compteClient;
            this.nbCommande = nbCommande;
            this.dateCreationCompte = dateCreationCompte;
            this.ville = ville;
        }

        public Client(int id_ss, string nom, string prenom, DateTime dateNaissance, string ville, string adresse, string mail, string numeroTel) : base(id_ss, nom, prenom, dateNaissance, adresse, mail, numeroTel)
        {
            this.statut = "Bronze";//nos nouveaux clients auront un statut Bronze
            this.compteClient = 0.0;
            this.nbCommande = 0;
            this.dateCreationCompte = DateTime.Now;
            this.ville = ville;
        } //pour les nouveaux clients

        public override string ToString()
        {
            return base.ToString() + "\n" + "Statut : " + statut + " Compte Client : " + compteClient + " Nombre de commandes : " + nbCommande + " Date de création du compte : " + dateCreationCompte;
        }

        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        public double CompteClient
        {
            get { return compteClient; }
            set { compteClient = value; }
        }

        public void AugCompteClient(double montant)
        {
            this.compteClient += montant;
        }

        public int NbCommande
        {
            get { return nbCommande; }
            set { nbCommande = value; }
        }

        public void NouvelleCom() //le client passe une nouvelle commande
        {
            this.nbCommande++;
        }

        public DateTime DateCreationCompte
        {
            get { return dateCreationCompte; }
            set { dateCreationCompte = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }


        public static List<Client> listeSClients = new List<Client>();

        public static void AjouterClient(Client Client)
        {
            listeSClients.Add(Client);
        }

        public static void SupprimerClient(Client Client)
        {
            listeSClients.Remove(Client);

        }

        public static List<Client> ObtenirListeClients()
        {
            return listeSClients;
        }

        public void MajStatut() //mettre à jour le statut du client lors d'une nouvelle commande de façon automatique
        {
            if(this.compteClient > 2000 && this.compteClient < 10000 && this.statut == "Bronze")
            {
                this.statut = "Argent";
            }

            if (this.compteClient > 10000 && (this.statut == "Argent" || this.statut == "Bronze"))
            {
                this.statut = "Or";
            }
        }

    }
}