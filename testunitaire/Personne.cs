using System;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public abstract class Personne //classe mère
    {
        protected int id_ss;
        protected string nom;
        protected string prenom;
        protected DateTime date_naissance;
        protected string adresse;
        protected string mail;
        protected string numero_tel;

        public Personne(int id_ss, string nom, string prenom, DateTime date_naissance, string adresse, string mail, string numero_tel)
        {
            this.id_ss = id_ss;
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.adresse = adresse;
            this.mail = mail;
            this.numero_tel = numero_tel;
        }

        public virtual string ToString()
        {
            return "\n" + "Nom : " + nom + " Prénom : " + prenom + " ID SS : " + id_ss + " Date de naissance : " + date_naissance + " Adresse : " + adresse + " Mail : " + mail + " Numéro de téléphone : " + numero_tel;
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string Numero
        {
            get { return numero_tel; }
            set { numero_tel = value; }
        }

        public int Id
        {
            get { return this.id_ss; }
        }
    }
}
