using System;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Salarie : Personne //classe fille de Personne
    {
        DateTime date_entree;
        string poste;
        int salaire; //Le salaire est le salaire horaire ici
        int nbLivraison;

        public Salarie(int id_ss, string nom, string prenom, DateTime date_naissance, string adresse, string mail, string numero_tel, DateTime date_entree, string poste, int salaire) : base(id_ss, nom, prenom, date_naissance, adresse, mail, numero_tel)
        {
            this.date_entree = date_entree;
            this.poste = poste;
            this.salaire = salaire;
            this.nbLivraison = 0;
        }

        //Nouveaux entrants :
        public Salarie(int id_ss, string nom, string prenom, DateTime date_naissance, string adresse, string mail, string numero_tel, string poste, int salaire) : base(id_ss, nom, prenom, date_naissance, adresse, mail, numero_tel)
        {
            this.date_entree = DateTime.Now;
            this.poste = poste;
            this.salaire = salaire;
            this.nbLivraison = 0;
        }

        //Ajouter une nouvlele livraison à un chauffeur
        public void NouvelleLiv()
        {
            this.nbLivraison++;
        }

        public void Supp1Liv()
        {
            this.nbLivraison--;
        }

        public override string ToString()
        {
            return base.ToString() + " Date d'entrée : " + date_entree.ToShortDateString() + " Poste : " + poste + " Salaire : " + salaire;
        }

        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }

        public int Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public new string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public new string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public new string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public new string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public new string Numero
        {
            get { return numero_tel; }
            set { numero_tel = value; }
        }

        public int NbLivraison
        {
            get { return nbLivraison; }
        }

    }
}
