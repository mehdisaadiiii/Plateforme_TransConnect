using System;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Vehicule //Flotte de véhicules
    {
        string nom;
        int nbPassager;
        string usage;
        int volume;
        string matiere;
        int nbBennes;
        bool grue;
        int groupeElectro;

        //Voitures :
        public Vehicule(int nbPassager)
        {
            this.nom = "Voiture";
            this.nbPassager = nbPassager;
        }

        //Camionette :
        public Vehicule(string usage)
        {
            this.nom = "Camionette";
            this.usage = usage;
        }

        //Camion Citerne :
        public Vehicule(int volume, string matiere)
        {
            this.nom = "Camion citerne";
            this.volume = volume;
            this.matiere = matiere;
        }

        //Camion Benne :
        public Vehicule(int volume, string matiere, int nbBennes, bool grue)
        {
            this.nom = "Camion Benne";
            this.volume = volume;
            this.matiere = matiere;
            if (nbBennes >= 1 && nbBennes <= 3)
            {
                this.nbBennes = nbBennes;
            }
            else
            {
                Console.WriteLine("Erreur : Le nombre de bennes doit être compris entre 1 et 3. La valeur par défaut (1 benne) sera utilisée.");
                this.nbBennes = 1; // Valeur par défaut
            }
            this.grue = grue;
        }

        //Camion Frigorifique
        public Vehicule(int volume, string matiere, int groupeElectro)
        {
            this.nom = "Camion Frigorifique";
            this.volume = volume;
            this.matiere = matiere;
            this.groupeElectro = groupeElectro;
        }

        public string Nom
        {
            get { return this.nom; }
        }

        public int NbPassager
        {
            get { return this.nbPassager; }
        }

        public int Volume
        {
            get { return this.volume; }
        }

        public int NbBennes
        {
            get { return this.nbBennes; }
        }

        public bool Grue
        {
            get { return this.grue; }
        }

        public int GroupeElectro
        {
            get { return this.groupeElectro; }
        }
    }
}
