using System;
namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Commande //classe commande
    {
        static int dernierIdCommande = 0;
        int id_Commande;
        Client a;
        string villeDep;
        string villeArr;
        double prix;
        Vehicule v;
        Salarie chauffeur;
        DateTime date;
        float duree;

        public Commande(Client a, string villeDep, string villeArr, float duree)
        {
            this.id_Commande = ++dernierIdCommande; //Auto-incrémentation des id_commandes
            this.a = a;
            this.villeDep = villeDep;
            this.villeArr = villeArr;
            this.date = DateTime.Today.AddDays(10); //10 jours de livraison
            this.v = ChoixVehicule();
            this.chauffeur = ChoixChauffeur(date);
            this.prix = CalculerPrix();
            this.duree = duree;
        }

        public Commande(int id_Commande, Client a, string villeDep, string villeArr, DateTime date, float duree, Vehicule v, Salarie c) //si une des villes d'arrivée ou de départ est modifiée
        {
            this.id_Commande = id_Commande; //Auto-incrémentation des id_commandes
            this.a = a;
            this.villeDep = villeDep;
            this.villeArr = villeArr;
            this.date = date;
            this.v = v;
            this.chauffeur = c;
            this.prix = CalculerPrix();
            this.duree = duree;
        }

        public Commande(int id_Commande, Client a, string villeDep, string villeArr, DateTime date, float duree, Vehicule v, double prix) //si une des villes d'arrivée ou de départ est modifiée
        {
            this.id_Commande = id_Commande; //Auto-incrémentation des id_commandes
            this.a = a;
            this.villeDep = villeDep;
            this.villeArr = villeArr;
            this.date = date;
            this.v = v;
            this.chauffeur = ChoixChauffeur(date); //on change de date, donc le chauffeur risque de ne plus être dispo
            this.prix = prix;
            this.duree = duree;
        }

        public Commande(Client a, string villeDep, string villeArr, DateTime date, float duree, Vehicule v) //pour la création de la bdd des commandes
        {
            this.id_Commande = ++dernierIdCommande; //Auto-incrémentation des id_commandes
            this.a = a;
            this.villeDep = villeDep;
            this.villeArr = villeArr;
            this.date = date;
            this.v = v;
            this.chauffeur = ChoixChauffeur(date);
            this.prix = CalculerPrix();
            this.duree = duree;
        }

        public Client A
        {
            get { return this.a; }
        }

        public float Duree
        {
            get { return this.duree; }
        }

        public int IdCom //Affichage de l'id_commande
        {
            get { return this.id_Commande; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string VilleD
        {
            get { return this.villeDep; }
            set { this.villeDep = value; }
        }

        public string VilleA
        {
            get { return this.villeArr; }
            set { this.villeArr = value; }
        }

        public double Prix
        {
            get { return this.prix; }
        }

        public Vehicule V
        {
            get { return this.v; }
        }

        public Salarie Chauffeur
        {
            get { return this.chauffeur; }
        }

        public Vehicule ChoixVehicule() //on ne permet pas la création de véhicule, il se crée automatiquement dans la commande grâce à cette méthode lorsqu'un client passe une commande
        {
            Console.WriteLine("De quel type de véhicule avez-vous besoin (saisissez le nombre associé au véhicule de votre choix) ?");
            Console.WriteLine("1. Voiture");
            Console.WriteLine("2. Camionette");
            Console.WriteLine("3. Camion citerne");
            Console.WriteLine("4. Camion benne");
            Console.WriteLine("5. Camion frigorifique");

            int choix;
            while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 5) //saisie sécurisée
            {
                Console.WriteLine("Veuillez entrer un nombre entre 1 et 5.");
            }

            switch (choix)
            {
                case 1:
                    Console.WriteLine("Combien de passagers la voiture devra-t-elle transporter ?");
                    int nbPassagers;
                    while (!int.TryParse(Console.ReadLine(), out nbPassagers) || nbPassagers <= 0)//saisie sécurisée
                    {
                        Console.WriteLine("Veuillez entrer un nombre de passagers valide.");
                    }
                    return new Vehicule(nbPassagers);

                case 2:
                    Console.WriteLine("Quel sera l'usage de la camionette ?");
                    string usage = Console.ReadLine();
                    return new Vehicule(usage);

                case 3:
                    Console.WriteLine("Quel sera le volume à transporter dans la cuve du camion citerne ?");
                    int volumeCiterne;
                    while (!int.TryParse(Console.ReadLine(), out volumeCiterne) || volumeCiterne <= 0)
                    {
                        Console.WriteLine("Veuillez entrer un volume valide.");
                    }
                    Console.WriteLine("Quelle matière le camion citerne transportera-t-il ?");
                    string matiereCiterne = Console.ReadLine();
                    return new Vehicule(volumeCiterne, matiereCiterne);

                case 4:
                    Console.WriteLine("Quel sera le volume de chargement du camion benne ?");
                    int volumeBenne;
                    while (!int.TryParse(Console.ReadLine(), out volumeBenne) || volumeBenne <= 0)
                    {
                        Console.WriteLine("Veuillez entrer un volume valide.");
                    }
                    Console.WriteLine("Quelle matière le camion benne transportera-t-il ?");
                    string matiereBenne = Console.ReadLine();
                    Console.WriteLine("De combien de bennes avez-vous besoin ?");
                    int nbBennes;
                    while (!int.TryParse(Console.ReadLine(), out nbBennes) || nbBennes < 1 || nbBennes > 3)
                    {
                        Console.WriteLine("Veuillez entrer un nombre de bennes valide entre 1 et 3.");
                    }
                    Console.WriteLine("Le camion benne aura-t-il une grue ? (true/false)");
                    bool Grue;
                    while (!bool.TryParse(Console.ReadLine(), out Grue))
                    {
                        Console.WriteLine("Veuillez entrer true ou false.");
                    }
                    return new Vehicule(volumeBenne, matiereBenne, nbBennes, Grue);

                case 5:
                    Console.WriteLine("Quel sera le volume de chargement du camion frigorifique ?");
                    int volumeFrigorifique;
                    while (!int.TryParse(Console.ReadLine(), out volumeFrigorifique) || volumeFrigorifique <= 0)
                    {
                        Console.WriteLine("Veuillez entrer un volume valide.");
                    }
                    Console.WriteLine("Quelle matière le camion frigorifique transportera-t-il ?");
                    string matiereFrigorifique = Console.ReadLine();
                    Console.WriteLine("De combien de groupe(s) électrogènes avez-vous besoin (1 ou plusieurs) ?");
                    int groupeElectro;
                    while (!int.TryParse(Console.ReadLine(), out groupeElectro) || groupeElectro <= 0)
                    {
                        Console.WriteLine("Veuillez entrer un nombre de groupe électrogène valide.");
                    }
                    return new Vehicule(volumeFrigorifique, matiereFrigorifique, groupeElectro);

                default:
                    throw new InvalidOperationException("Choix invalide.");
            }
        }

        public Salarie ChoixChauffeur(DateTime dateLivraison) //méthode permettant d'indiquer si un chaffeur est disponible à la date de livraison, sinon, on passe au chauffeur suivant
        {
            foreach (Salarie salarie in Entreprise.ObtenirListeSalaries())
            {
                if (salarie.Poste == "Chauffeur" && Dispo(salarie, dateLivraison))
                {
                    salarie.NouvelleLiv();
                    return salarie;
                }
            }
            return null;
        }

        // Méthode pour vérifier si un chauffeur est disponible à une date donnée
        public bool Dispo(Salarie chauffeur, DateTime date)
        {
            foreach (Commande commande in ListeCommande.ObtenirListeCommande())
            {
                if (commande.Chauffeur == chauffeur && commande.Date.Date == date.Date)
                {
                    // Le chauffeur est occupé à cette date
                    return false;
                }
            }

            // Le chauffeur n'a pas de livraison prévue à cette date
            return true;
        }

        
        public double CalculerPrix()
        {
            double prix = 0.0;
            prix += chauffeur.Salaire*(double)duree; //ici duree correspond à la durée du trajet

            //Partie coût du véhicule :
            if (v.Nom == "Voiture")
            {
                prix += v.NbPassager * 20 + 200; //20 euros par passagers + 200 euros de frais pour la voiture
            }
            else if (v.Nom == "Camionette")
            {
                prix += 400; //400 euros pour une camionette
            }
            else if (v.Nom == "Camion citerne")
            {
                prix += v.Volume * 10 + 500; //10 euros par litres + 500 euros de frais
            }
            else if (v.Nom == "Camion Benne")
            {
                prix += v.Volume * 10 + 500 + v.NbBennes*300; //même chose qu'avant + 300 euros/bennes
                if(v.Grue)
                {
                    prix += 1000; //1000 euros si présence de grue
                }
            }
            else if(v.Nom == "Camion Frigorifique")
            {
                prix += v.Volume * 10 + 500 +v.GroupeElectro*300; //10 euros par litres + 500 euros de frais +300 euros / groupe électro
            }
            a.CompteClient += prix;
            a.NbCommande++;
            if(a.Statut == "Argent")//réduction du prix si le client a un statut Argent
            {
                prix = prix - (double)((10 / 100) * prix); //(réduction de 10%)
            }
            if (a.Statut == "Or")//réduction du prix si le client a un statut Or
            {
                prix = prix - (double)((25 / 100) * prix); //(réduction de 25%)
            }
            a.MajStatut(); //maj du statut du client lors d'une nouvelle commande
            return prix;
        }

        public override string ToString()
        {
            return "\nRécapitulatif de votre commande : "+"\nId de la commande : " + this.id_Commande + "\nN° de client : " + this.a.Id + "\nTrajet : " + this.villeDep
                + "-" + this.villeArr + "\nType de véhicule : " + this.v.Nom + "\nChauffeur : " + this.chauffeur.Prenom + " "
                + this.chauffeur.Nom + "\nDate de livraison : " + this.date.ToShortDateString() + "\nPrix de votre commande : " + this.prix + " euros.";
        }

        public void AfficherPrixCommande()
        {
            Console.WriteLine("Liste des commandes : \n");
            Console.WriteLine("N°Identification de la commande :"+this.id_Commande + " Prix de la commande : " + this.prix);
        }

        

        //calculer la distance à effectuer avec Dijkstra
    }
}
