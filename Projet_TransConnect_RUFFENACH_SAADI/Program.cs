using System;
using System.Collections.Generic;
using System.Threading;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    class MainClass
    {
        //Base de l'entreprise
        static Arbre Base23()
        {
            Salarie directeurGeneral = new Salarie(01, "Dupond", "Eric", new DateTime(1980, 1, 1), "3 rue de la Source", "eric.dupont@transconnect.fr", "0876876987", new DateTime(2023, 12, 3), "Directeur Général", 5000);
            Salarie directriceCommerciale = new Salarie(02, "Fiesta", "Mme", new DateTime(1985, 3, 15), "Adresse", "email@exemple.com", "0123456789", new DateTime(2022, 5, 10), "Directrice Commerciale", 600);
            Salarie commercial1 = new Salarie(06, "Forge", "Mr", new DateTime(1990, 7, 20), "Adresse", "email@exemple.com", "0123456789", new DateTime(2022, 6, 5), "Commercial", 400);
            Salarie commerciale2 = new Salarie(07, "Fermi", "Mme", new DateTime(1988, 9, 25), "Adresse", "email@exemple.com", "0123456789", new DateTime(2022, 8, 15), "Commerciale", 450);
            Salarie directeurOperations = new Salarie(03, "Fetard", "Mr", new DateTime(1983, 11, 10), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 1, 20), "Directeur des opérations", 700);

            Salarie chefEquipe1 = new Salarie(08, "Royal", "Mr", new DateTime(1975, 4, 5), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 3, 12), "Chef Equipe 1", 55);

            Salarie chauffeur1 = new Salarie(14, "Romu", "Mr", new DateTime(1982, 2, 18), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 4, 22), "Chauffeur", 80);
            Salarie chauffeur2 = new Salarie(15, "Romi", "Mme", new DateTime(1987, 6, 30), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 5, 30), "Chauffeur", 70);
            Salarie chauffeur3 = new Salarie(16, "Roma", "Mr", new DateTime(1980, 8, 12), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 7, 15), "Chauffeur", 70);

            Salarie chefEquipe2 = new Salarie(09, "Prince", "Mme", new DateTime(1978, 10, 8), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 8, 10), "Chef d'Equipe 2", 60);

            Salarie chauffeur4 = new Salarie(17, "Rome", "Mme", new DateTime(1984, 12, 3), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 9, 5), "Chauffeur", 50);
            Salarie chauffeur5 = new Salarie(18, "Rimou", "Mme", new DateTime(1993, 1, 25), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 10, 20), "Chauffeur", 50);

            Salarie directriceRH = new Salarie(04, "Joyeuse", "Mme", new DateTime(1970, 11, 15), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 11, 15), "Directrice des RH", 80);
            Salarie formation1 = new Salarie(10, "CouleurFormation", "Mme", new DateTime(1979, 8, 20), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 12, 1), "Formation", 48);
            Salarie contrats = new Salarie(11, "ToutleMonde", "Mme", new DateTime(1989, 5, 3), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 12, 15), "Contrats", 40);
            Salarie directeurFinancier = new Salarie(05, "GripSous", "Mr", new DateTime(1986, 4, 12), "Adresse", "email@exemple.com", "0123456789", new DateTime(2024, 1, 2), "Directeur Financier", 750);
            Salarie directionComptable = new Salarie(12, "Picsou", "Mr", new DateTime(1977, 7, 23), "Adresse", "email@exemple.com", "0123456789", new DateTime(2024, 2, 10), "Direction comptable", 700);
            Salarie comptable1 = new Salarie(19, "Fournier", "Mme", new DateTime(1981, 10, 5), "Adresse", "email@exemple.com", "0123456789", new DateTime(2024, 3, 20), "Comptable", 450);
            Salarie comptable2 = new Salarie(20, "Gautier", "Mme", new DateTime(1974, 3, 8), "Adresse", "email@exemple.com", "0123456789", new DateTime(2024, 4, 5), "Comptable", 460);
            Salarie controleurGestion = new Salarie(13, "GrosSous", "Mr", new DateTime(1980, 5, 10), "Adresse", "email@exemple.com", "0123456789", new DateTime(2024, 5, 1), "Controleur de Gestion", 650);

            Entreprise.AjouterSalarie(directeurGeneral);
            Entreprise.AjouterSalarie(directriceCommerciale);
            Entreprise.AjouterSalarie(commercial1);
            Entreprise.AjouterSalarie(commerciale2);
            Entreprise.AjouterSalarie(directeurOperations);
            Entreprise.AjouterSalarie(chefEquipe1);
            Entreprise.AjouterSalarie(chauffeur1);
            Entreprise.AjouterSalarie(chauffeur2);
            Entreprise.AjouterSalarie(chauffeur3);
            Entreprise.AjouterSalarie(chefEquipe2);
            Entreprise.AjouterSalarie(chauffeur4);
            Entreprise.AjouterSalarie(chauffeur5);
            Entreprise.AjouterSalarie(directriceRH);
            Entreprise.AjouterSalarie(formation1);
            Entreprise.AjouterSalarie(contrats);
            Entreprise.AjouterSalarie(directeurFinancier);
            Entreprise.AjouterSalarie(directionComptable);
            Entreprise.AjouterSalarie(comptable1);
            Entreprise.AjouterSalarie(comptable2);
            Entreprise.AjouterSalarie(controleurGestion);

            //niveau 1
            Arbre organigramme = new Arbre(directeurGeneral);

            //niveau 2
            organigramme.AjouterSousDirecteur(directeurGeneral, directriceCommerciale);
            organigramme.AjouterSousDirecteur(directeurGeneral, directeurOperations);
            organigramme.AjouterSousDirecteur(directeurGeneral, directriceRH);
            organigramme.AjouterSousDirecteur(directeurGeneral, directeurFinancier);

            //niveau 3
            organigramme.AjouterSousDirecteur(directriceCommerciale, commercial1);
            organigramme.AjouterSousDirecteur(directriceCommerciale, commerciale2);

            organigramme.AjouterSousDirecteur(directeurOperations, chefEquipe1);
            organigramme.AjouterSousDirecteur(directeurOperations, chefEquipe2);

            organigramme.AjouterSousDirecteur(directriceRH, formation1);
            organigramme.AjouterSousDirecteur(directriceRH, contrats);

            organigramme.AjouterSousDirecteur(directeurFinancier, directionComptable);
            organigramme.AjouterSousDirecteur(directeurFinancier, controleurGestion);

            //niveau 4
            organigramme.AjouterSousDirecteur(chefEquipe1, chauffeur1);
            organigramme.AjouterSousDirecteur(chefEquipe1, chauffeur2);
            organigramme.AjouterSousDirecteur(chefEquipe1, chauffeur3);

            organigramme.AjouterSousDirecteur(chefEquipe2, chauffeur4);
            organigramme.AjouterSousDirecteur(chefEquipe2, chauffeur5);

            organigramme.AjouterSousDirecteur(directionComptable, comptable1);
            organigramme.AjouterSousDirecteur(directionComptable, comptable2);

            return organigramme; //retourner orga

            //organigramme.AfficherOrga();
        } //base des salariés
        static void Base24()
        {
            Client client1 = new Client(1, "Dupont", "Jean", new DateTime(1985, 7, 15), "Paris", "123 Rue de la Liberté", "jean.dupont@gmail.com", "0123456789", "Bronze", 1000.50, 5, new DateTime(2020, 3, 10));
            Client client2 = new Client(2, "Martin", "Sophie", new DateTime(1990, 5, 20), "Marseille", "456 Avenue des Roses", "sophie.martin@gmail.com", "0987654321", "Argent", 7750.25, 3, new DateTime(2018, 8, 22));
            Client client3 = new Client(3, "Dubois", "Pierre", new DateTime(1978, 12, 8), "Lyon", "789 Boulevard du Soleil", "pierre.dubois@gmail.com", "0654321879", "Or", 12500.75, 8, new DateTime(2015, 11, 5));
            Client client4 = new Client(4, "Lefevre", "Marie", new DateTime(1992, 9, 28), "Paris", "987 Rue de la Paix", "marie.lefevre@gmail.com", "0234567890", "Bronze", 1500.30, 6, new DateTime(2019, 6, 15));
            Client client5 = new Client(5, "Moreau", "Luc", new DateTime(1980, 3, 10), "Marseille", "654 Avenue des Champs", "luc.moreau@gmail.com", "0789456123", "Argent", 4200.50, 1, new DateTime(2023, 2, 18));
            Client client6 = new Client(6, "Garcia", "Ana", new DateTime(1975, 11, 5), "Lyon", "321 Boulevard de la Mer", "ana.garcia@gmail.com", "0369852147", "Bronze", 300.00, 10, new DateTime(2017, 9, 20));
            Client client7 = new Client(7, "Roux", "David", new DateTime(1988, 6, 12), "Paris", "741 Avenue des Orangers", "david.roux@gmail.com", "0541237896", "Or", 55000.75, 12, new DateTime(2014, 4, 25));
            Client client8 = new Client(8, "Fournier", "Julie", new DateTime(1995, 4, 17), "Marseille", "852 Rue des Lilas", "julie.fournier@gmail.com", "0321546879", "Argent", 6100.00, 3, new DateTime(2024, 1, 8));
            Client client9 = new Client(9, "Sanchez", "Carlos", new DateTime(1983, 10, 3), "Paris", "159 Boulevard des Pins", "carlos.sanchez@gmail.com", "0698745213", "Bronze", 1200.45, 7, new DateTime(2016, 10, 12));
            Client client10 = new Client(10, "Leroy", "Isabelle", new DateTime(1987, 8, 20), "Lyon", "369 Avenue du Lac", "isabelle.leroy@gmail.com", "0456781234", "Bronze", 300.60, 3, new DateTime(2021, 7, 10));
            Client client11 = new Client(11, "Girard", "Antoine", new DateTime(1993, 11, 15), "Paris", "258 Rue des Roses", "antoine.girard@gmail.com", "0987123456", "Argent", 8750.25, 2, new DateTime(2022, 5, 5));
            Client client12 = new Client(12, "Martin", "Claire", new DateTime(1970, 4, 5), "Marseille", "753 Boulevard du Parc", "claire.martin@gmail.com", "0369852478", "Or", 77000.00, 15, new DateTime(2013, 12, 18));
            Client client13 = new Client(13, "Lambert", "Paul", new DateTime(1984, 9, 10), "Paris", "456 Rue des Érables", "paul.lambert@gmail.com", "0123456789", "Bronze", 1200.75, 9, new DateTime(2019, 8, 7));
            Client client14 = new Client(14, "Fontaine", "Sophie", new DateTime(1998, 2, 25), "Lyon", "789 Avenue des Alouettes", "sophie.fontaine@gmail.com", "0987654321", "Argent", 3480.50, 1, new DateTime(2023, 3, 15));
            Client client15 = new Client(15, "Perrin", "Jeanne", new DateTime(1977, 5, 12), "Paris", "123 Boulevard des Cerisiers", "jeanne.perrin@gmail.com", "0654321879", "Or", 33500.25, 11, new DateTime(2016, 11, 25));
            Client client16 = new Client(16, "Giroux", "Lucie", new DateTime(1982, 10, 8), "Marseille", "369 Avenue de la Paix", "lucie.giroux@gmail.com", "0234567890", "Bronze", 1800.30, 7, new DateTime(2020, 4, 12));
            Client client17 = new Client(17, "Rousseau", "Philippe", new DateTime(1991, 3, 21), "Paris", "456 Rue des Violettes", "philippe.rousseau@gmail.com", "0789456123", "Argent", 7230.75, 2, new DateTime(2023, 9, 28));
            Client client18 = new Client(18, "Gagnon", "Marcel", new DateTime(1979, 7, 15), "Lyon", "789 Boulevard de la Liberté", "marcel.gagnon@gmail.com", "0369852147", "Or", 34200.00, 10, new DateTime(2018, 5, 20));
            Client client19 = new Client(19, "Bergeron", "Émilie", new DateTime(1986, 12, 3), "Paris", "159 Avenue du Soleil", "emilie.bergeron@gmail.com", "0541237896", "Bronze", 250.50, 8, new DateTime(2021, 10, 5));
            Client client20 = new Client(20, "Beaulieu", "Pauline", new DateTime(1994, 5, 18), "Marseille", "852 Rue des Roses", "pauline.beaulieu@gmail.com", "0321546879", "Argent", 3150.00, 1, new DateTime(2024, 3, 8));



            ListeClients.AjouterClient(client1);
            ListeClients.AjouterClient(client2);
            ListeClients.AjouterClient(client3);
            ListeClients.AjouterClient(client4);
            ListeClients.AjouterClient(client5);
            ListeClients.AjouterClient(client6);
            ListeClients.AjouterClient(client7);
            ListeClients.AjouterClient(client8);
            ListeClients.AjouterClient(client9);
            ListeClients.AjouterClient(client10);
            ListeClients.AjouterClient(client11);
            ListeClients.AjouterClient(client12);
            ListeClients.AjouterClient(client13);
            ListeClients.AjouterClient(client14);
            ListeClients.AjouterClient(client15);
            ListeClients.AjouterClient(client16);
            ListeClients.AjouterClient(client17);
            ListeClients.AjouterClient(client18);
            ListeClients.AjouterClient(client19);
            ListeClients.AjouterClient(client20);

            Vehicule voiture1 = new Vehicule(10);
            Vehicule voiture2 = new Vehicule(15);
            Vehicule camionnette = new Vehicule("transport d'outils de jardinage");
            Vehicule camionciterne = new Vehicule(200, "goudron");
            Vehicule benne = new Vehicule(1400, "pétrole", 2, true);

            List<Noeud1> listNoeuds = CreerDonneesManuelles();
            Graphe graphe = new Graphe(listNoeuds);
            Noeud1 depart = listNoeuds.Find(n => n.Symbole == "Paris");
            Noeud1 arrivee = listNoeuds.Find(n => n.Symbole == "Bordeaux");

            // Exécution de l'algorithme de Dijkstra à partir du graphe
            List<Etape> etapes = graphe.Dijkstra(depart, arrivee);
            float duree1 = graphe.CalculerDuree(etapes);//durée de la commande 1
            Commande c1 = new Commande(client1, "Paris", "Bordeaux", new DateTime(2024, 5, 30), duree1, voiture1);
            ListeCommande.AjouterCommande(c1);

            depart = listNoeuds.Find(n => n.Symbole == "Pau");
            arrivee = listNoeuds.Find(n => n.Symbole == "Toulon");
            etapes = graphe.Dijkstra(depart, arrivee);
            duree1 = graphe.CalculerDuree(etapes);//durée de la commande 2
            Commande c2 = new Commande(client2, "Pau", "Toulon", new DateTime(2024, 5, 30), duree1, voiture2);
            ListeCommande.AjouterCommande(c2);

            depart = listNoeuds.Find(n => n.Symbole == "Nimes");
            arrivee = listNoeuds.Find(n => n.Symbole == "Angers");
            etapes = graphe.Dijkstra(depart, arrivee);
            duree1 = graphe.CalculerDuree(etapes);//durée de la commande 3
            Commande c3 = new Commande(client10, "Nimes", "Angers", new DateTime(2024, 5, 30), duree1, camionnette);
            ListeCommande.AjouterCommande(c3);

            depart = listNoeuds.Find(n => n.Symbole == "Rouen");
            arrivee = listNoeuds.Find(n => n.Symbole == "Montpellier");
            etapes = graphe.Dijkstra(depart, arrivee);
            duree1 = graphe.CalculerDuree(etapes);//durée de la commande 4
            Commande c4 = new Commande(client10, "Rouen", "Montpellier", new DateTime(2024, 6, 30), duree1, camionciterne);
            ListeCommande.AjouterCommande(c4);

            depart = listNoeuds.Find(n => n.Symbole == "Marseilles");
            arrivee = listNoeuds.Find(n => n.Symbole == "Paris");
            etapes = graphe.Dijkstra(depart, arrivee);
            duree1 = graphe.CalculerDuree(etapes);//durée de la commande 5
            Commande c5 = new Commande(client19, "Marseilles", "Paris", new DateTime(2024, 6, 25), duree1, benne);
            ListeCommande.AjouterCommande(c5);
        } //base des clients + commande
        static List<Noeud1> CreerDonneesManuelles()
        {
            List<Noeud1> listNoeuds = new List<Noeud1>();

            // Ajout manuel des noeuds et des liens
            Noeud1 paris = new Noeud1("Paris");
            Noeud1 lyon = new Noeud1("Lyon");
            Noeud1 marseille = new Noeud1("Marseilles");

            Noeud1 angers = new Noeud1("Angers");
            Noeud1 larochelle = new Noeud1("La Rochelle");
            Noeud1 bordeaux = new Noeud1("Bordeaux");
            Noeud1 biarritz = new Noeud1("Biarritz");
            Noeud1 toulouse = new Noeud1("Toulouse");
            Noeud1 pau = new Noeud1("Pau");
            Noeud1 nimes = new Noeud1("Nimes");
            Noeud1 montpellier = new Noeud1("Montpellier");
            Noeud1 avignon = new Noeud1("Avignon");
            Noeud1 monaco = new Noeud1("Monaco");
            Noeud1 toulon = new Noeud1("Toulon");
            Noeud1 rouen = new Noeud1("Rouen");
            // Ajoutez d'autres noeuds selon vos besoins

            // Ajout manuel des liens
            paris.AjouterArrivant(133, 1.75f, rouen);
            rouen.AjouterArrivant(133, 1.75f, paris);

            paris.AjouterArrivant(464, 1.92f, lyon);
            lyon.AjouterArrivant(464, 1.92f, paris);

            paris.AjouterArrivant(294, 3.18f, angers);
            angers.AjouterArrivant(294, 3.18f, paris);

            angers.AjouterArrivant(187, 2.33f, larochelle);
            larochelle.AjouterArrivant(187, 2.33f, angers);

            larochelle.AjouterArrivant(183, 1.63f, bordeaux);
            bordeaux.AjouterArrivant(183, 1.63f, larochelle);

            bordeaux.AjouterArrivant(202, 1.78f, biarritz);
            biarritz.AjouterArrivant(202, 1.78f, bordeaux);

            biarritz.AjouterArrivant(309, 2.65f, toulouse);
            toulouse.AjouterArrivant(309, 2.65f, biarritz);

            pau.AjouterArrivant(193, 1.68f, toulouse);
            toulouse.AjouterArrivant(193, 1.68f, pau);

            nimes.AjouterArrivant(289, 2.43f, toulouse);
            toulouse.AjouterArrivant(289, 2.43f, nimes);

            montpellier.AjouterArrivant(52, 0.58f, nimes);
            nimes.AjouterArrivant(52, 0.58f, montpellier);

            nimes.AjouterArrivant(126, 1.22f, marseille);
            marseille.AjouterArrivant(126, 1.22f, nimes);

            marseille.AjouterArrivant(99, 1f, avignon);
            avignon.AjouterArrivant(99, 1f, marseille);

            monaco.AjouterArrivant(224, 2.05f, marseille);
            marseille.AjouterArrivant(224, 2.05f, monaco);

            toulon.AjouterArrivant(169, 1.58f, monaco);
            monaco.AjouterArrivant(169, 1.58f, toulon);

            // Ajoutez d'autres liens selon vos besoins

            // Ajout des noeuds à la liste
            listNoeuds.Add(paris);
            listNoeuds.Add(lyon);
            listNoeuds.Add(marseille);
            listNoeuds.Add(angers);
            listNoeuds.Add(larochelle);
            listNoeuds.Add(bordeaux);
            listNoeuds.Add(biarritz);
            listNoeuds.Add(toulouse);
            listNoeuds.Add(pau);
            listNoeuds.Add(nimes);
            listNoeuds.Add(montpellier);
            listNoeuds.Add(avignon);
            listNoeuds.Add(monaco);
            listNoeuds.Add(toulon);
            listNoeuds.Add(rouen);



            // Ajoutez d'autres noeuds à la liste selon vos besoins

            return listNoeuds;
        } //base des noeuds/distances pour Dijkstra


        public static void Main(string[] args)
        {
            Arbre first = Base23(); //base des salariés + organigramme d'où l'arbre
            Base24(); //base des clients + commandes
            ClientInterface interc = new ClientInterface();
            SalarieInterface inters = new SalarieInterface();
            CommandeInterFace intercc = new CommandeInterFace();
            // Création des noeuds et des liens manuellement
            List<Noeud1> listNoeuds = CreerDonneesManuelles();

            // Création du graphe pour Dijkstra
            Graphe graphe = new Graphe(listNoeuds);

            Console.ForegroundColor = ConsoleColor.Red;
            string message = "Bonjour ! Bienvenue chez TransConnect";
            int leftPadding = (Console.WindowWidth - message.Length) / 2;
            Console.WriteLine(message.PadLeft(leftPadding + message.Length));
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.WriteLine("\n");

            bool connexionReussie = false;

            while (!connexionReussie) //identifiants corrects
            {
                Console.WriteLine("Pour démarrer, merci de vous connecter :"); //page accueil
                Console.WriteLine("\n");
                Console.WriteLine("Email : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string email = Convert.ToString(Console.ReadLine());
                Console.ResetColor();
                Console.WriteLine("\n");
                Console.WriteLine("Mot de passe : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string mdp = GetPasswordInput();
                Console.ResetColor();
                Console.WriteLine("\n");

                // Vérification des identifiants
                if (email == "eric.dupont@transconnect.fr" && mdp == "Esilv")
                {
                    // Utilisateur connecté avec succès
                    Console.Clear();
                    Console.WriteLine("Connexion réussie ! Bienvenue Monsieur Dupont\n");
                    connexionReussie = true;

                    bool retourPageAccueil = false;
                    while (!retourPageAccueil) //menu
                    {
                        Console.WriteLine("Quel module souhaitez-vous ouvrir (tapez 1, 2, 3, 4, ou 5) :");
                        Console.WriteLine("\n1- Module Salariés");
                        Console.WriteLine("\n2- Module Clients");
                        Console.WriteLine("\n3- Module Commande");
                        Console.WriteLine("\n4- Module Statistiques");
                        Console.WriteLine("\n5- Module Autre");

                        int choixModule = Convert.ToInt32(Console.ReadLine());

                        switch (choixModule) //chaque case correspond à un module
                        {
                            case 1: //dans chaque case, on trouve des if/else qui correspondent aux différentes méthodes que nous proposons
                                OuvrirModuleSalarie();
                                Console.WriteLine("Que souhaitez-vous faire ?");
                                Console.WriteLine("\n1- Afficher l'organigramme de votre entreprise \n\n2- Embaucher un salarié " +
                                    "\n\n3- Licencier un salarié \n\n4- Exclure un salarié de l'organigramme ? (tapez 1, 2, 3 ou 4)");
                                int choix1 = Convert.ToInt32(Console.ReadLine());
                                if(choix1 == 1)
                                {
                                    first.AfficherOrga();
                                }
                                else if(choix1 == 2)
                                {
                                    Console.WriteLine("Cellule de Recrutement \n");
                                    Console.WriteLine("Souhaitez-vous recruter des chefs d'équipe (1) ou des chauffeurs (2) ? \n");
                                    int choix22 = Convert.ToInt32(Console.ReadLine());
                                    if(choix22 == 1)
                                    {
                                        Console.WriteLine("Bienvenue à notre nouveau chef d'équipe !\n");
                                        string poste = "Chef d'Equipe";
                                        int salaire = 20; //les chefs d'équipes sont payés 20 euros de l'heure au recrutement
                                        Console.WriteLine("Quel est votre numéro de sécurité social :");
                                        int id_ss = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quel est votre nom :");
                                        string nom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre prénom :");
                                        string prenom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre adresse mail :");
                                        string mail = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre adresse postale :");
                                        string adresse = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre numéro de téléphone :");
                                        string num = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre jour de naissance :");
                                        int jour = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quel est votre mois de naissance :");
                                        int mois = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre année de naissance :");
                                        int annee = Convert.ToInt32(Console.ReadLine());
                                        DateTime date_naissance = new DateTime(annee, mois, jour);
                                        Salarie nouvChefEquipe = new Salarie(id_ss, nom, prenom, date_naissance, adresse, mail, num, poste, salaire);
                                        Entreprise.AjouterSalarie(nouvChefEquipe);

                                        Console.WriteLine("Voulez-vous inclure ce nouveau salarié dans l'organigramme (écrire oui ou non) ?");
                                        string rep = Convert.ToString(Console.ReadLine());
                                        if(rep == "oui")
                                        {
                                            Salarie directeurOperations = Entreprise.Find("Directeur des opérations");
                                            first.AjouterSousDirecteur(directeurOperations, nouvChefEquipe);
                                            first.AfficherOrga();
                                        }
                                        else
                                        {
                                            first.AfficherOrga();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bienvenue à notre nouveau chauffeur !\n");
                                        string poste = "Chauffeur";
                                        int salaire = 10; //les chefs d'équipes sont payés 10 euros de l'heure au recrutement
                                        Console.WriteLine("Quel est votre numéro de sécurité social :");
                                        int id_ss = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quel est votre nom :");
                                        string nom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre prénom :");
                                        string prenom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre adresse mail :");
                                        string mail = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre adresse postale :");
                                        string adresse = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre numéro de téléphone :");
                                        string num = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre jour de naissance :");
                                        int jour = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quel est votre mois de naissance :");
                                        int mois = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre année de naissance :");
                                        int annee = Convert.ToInt32(Console.ReadLine());
                                        DateTime date_naissance = new DateTime(annee, mois, jour);
                                        Salarie nouvChauffeur = new Salarie(id_ss, nom, prenom, date_naissance, adresse, mail, num, poste, salaire);
                                        Entreprise.AjouterSalarie(nouvChauffeur);

                                        Console.WriteLine("Voulez-vous inclure ce nouveau salarié dans l'organigramme (écrire oui ou non) ?");
                                        string rep = Convert.ToString(Console.ReadLine());
                                        if (rep == "oui")
                                        {
                                            Salarie chefEquipe = Entreprise.Find("Chef d'Equipe 2");
                                            first.AjouterSousDirecteur(chefEquipe, nouvChauffeur);
                                            first.AfficherOrga();
                                        }
                                        else
                                        {
                                            first.AfficherOrga();
                                        }
                                    }
                                }
                                else if(choix1 == 3)
                                {
                                    Console.WriteLine("Licenciement d'un salarié : \n");
                                    Console.WriteLine("Quel est le nom du salarié que vous souhaitez licencier ?");
                                    string nom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est le prénom du salarié que vous souhaitez licencier ?");
                                    string prenom = Convert.ToString(Console.ReadLine());
                                    Salarie bye = Entreprise.Find(nom, prenom);
                                    if(bye != null)
                                    {
                                        first.SupprimerNoeud(bye);
                                        Entreprise.SupprimerSalarie(bye);
                                        Console.WriteLine("\nLe salarié a bien été licencié et supprimé de l'organigramme : \n");
                                        first.AfficherOrga();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLe salarié est introuvable, veuillez réésayer. \n");
                                    }
                                }
                                else if(choix1 == 4)
                                {
                                    Console.WriteLine("Exclusion d'un salarié de l'organigramme : \n");
                                    Console.WriteLine("Quel est le nom du salarié que vous souhaitez exclure ?");
                                    string nom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est le prénom du salarié que vous souhaitez exclure ?");
                                    string prenom = Convert.ToString(Console.ReadLine());
                                    Salarie bye = Entreprise.Find(nom, prenom);
                                    if(bye != null)
                                    {
                                        first.SupprimerNoeud(bye);
                                        Console.WriteLine("\nLe salarié a bien été supprimé de l'organigramme : \n");
                                        first.AfficherOrga();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLe salarié est introuvable, veuillez réésayer. \n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Erreur");
                                }
                                break;
                            case 2:
                                OuvrirModuleClient();
                                Console.WriteLine("Que souhaitez-vous faire ?");
                                Console.WriteLine("\n1- Créer un nouveau client \n\n2- Supprimer un client " +
                                    "\n\n3- Modifier un client \n\n4- Afficher les clients ? (tapez 1, 2, 3 ou 4)");
                                int choix2 = Convert.ToInt32(Console.ReadLine());
                                if(choix2 == 1)
                                {
                                    Console.WriteLine("Création d'un nouveau client \n");
                                    Console.WriteLine("Quel est votre numéro de sécurité social :");
                                    int id_ss = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quel est votre nom :");
                                    string nom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est votre prénom :");
                                    string prenom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quelle est votre adresse mail :");
                                    string mail = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quelle est votre adresse postale :");
                                    string adresse = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quelle est votre ville de résidence ?");
                                    string ville = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est votre numéro de téléphone :");
                                    string num = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est votre jour de naissance :");
                                    int jour = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quel est votre mois de naissance :");
                                    int mois = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quelle est votre année de naissance :");
                                    int annee = Convert.ToInt32(Console.ReadLine());
                                    DateTime date_naissance = new DateTime(annee, mois, jour);
                                    Client a = new Client(id_ss, nom, prenom, date_naissance, ville, adresse, mail, num);
                                    ListeClients.AjouterClient(a);//ajout à la liste des clients
                                    Console.WriteLine("Bienvenue chez TransConnect, " + a.Nom + " " + a.Prenom);
                                    Console.WriteLine(a.ToString());
                                }
                                else if(choix2 == 2)
                                {
                                    Console.WriteLine("Suppression d'un client \n");
                                    Console.WriteLine("Quel est le nom du client que vous souhaitez supprimer ?");
                                    string nom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est le prénom du client que vous souhaitez supprimer ?");
                                    string prenom = Convert.ToString(Console.ReadLine());

                                    Client bye = ListeClients.Find(nom, prenom);
                                    ListeClients.SupprimerClient(bye); //Suppression

                                    Console.WriteLine("\nLe client a bien été supprimé. \n");
                                }
                                else if(choix2 == 3)
                                {
                                    Console.WriteLine("Modification d'un client : ");
                                    Console.WriteLine("1- Modifier son nom \n2- Modifier son adresse " +
                                    "\n3- Modifier son numéro de téléphone \n4- Modifier son mail ? (tapez 1, 2, 3 ou 4)");
                                    int zz = Convert.ToInt32(Console.ReadLine());
                                    if(zz == 1)
                                    {
                                        Console.WriteLine("Modification du nom du client : ");
                                        Console.WriteLine("Quel est le nom du client que vous souhaitez modifier ?");
                                        string nom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est le prénom du client que vous souhaitez modifier ?");
                                        string prenom = Convert.ToString(Console.ReadLine());
                                        Client b = ListeClients.Find(nom, prenom);
                                        Console.WriteLine("Quel est le nouveau nom de ce client ?");
                                        b.Nom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Modification effectuée !");
                                        Console.WriteLine(b.ToString());
                                    }
                                    else if(zz == 2)
                                    {
                                        Console.WriteLine("Modification de l'adresse du client : ");
                                        Console.WriteLine("Quel est le nom du client que vous souhaitez modifier ?");
                                        string nom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est le prénom du client que vous souhaitez modifier ?");
                                        string prenom = Convert.ToString(Console.ReadLine());
                                        Client b = ListeClients.Find(nom, prenom);
                                        Console.WriteLine("Quelle est la nouvelle adresse de ce client ?");
                                        b.Adresse = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Modification effectuée !");
                                        Console.WriteLine(b.ToString());
                                    }
                                    else if(zz == 3)
                                    {
                                        Console.WriteLine("Modification du numéro de téléphone du client : ");
                                        Console.WriteLine("Quel est le nom du client que vous souhaitez modifier ?");
                                        string nom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est le prénom du client que vous souhaitez modifier ?");
                                        string prenom = Convert.ToString(Console.ReadLine());
                                        Client b = ListeClients.Find(nom, prenom);
                                        Console.WriteLine("Quel est le nouveau numéro de téléphone de ce client ?");
                                        b.Numero = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Modification effectuée !");
                                        Console.WriteLine(b.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Modification de l'adresse mail du client : ");
                                        Console.WriteLine("Quel est le nom du client que vous souhaitez modifier ?");
                                        string nom = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est le prénom du client que vous souhaitez modifier ?");
                                        string prenom = Convert.ToString(Console.ReadLine());
                                        Client b = ListeClients.Find(nom, prenom);
                                        Console.WriteLine("Quelle est la nouvelle adresse mail de ce client ?");
                                        b.Mail = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Modification effectuée !");
                                        Console.WriteLine(b.ToString());
                                    }
                                }
                                else if(choix2 == 4)
                                {
                                    Console.WriteLine("Affichage des clients : \n");
                                    Console.WriteLine("Affichage par ordre alphabétique du nom : ");
                                    interc.AfficherClientsParNom();
                                    Console.WriteLine("\n Affichage des clients par ville : ");
                                    interc.AfficherClientsParVille();
                                    Console.WriteLine("\n Affichage des clients par montants des achats cumulés (par somme des achats cumulés) : ");
                                    interc.AfficherComptesDecroissant();
                                    Console.WriteLine("\n Affichage des clients par moyenne des achats cumulés (par moyenne des achats cumulés par le nombre de commande) : ");
                                    interc.AfficherRapportsDecroissant();
                                }
                                else
                                {
                                    Console.WriteLine("Erreur");
                                }
                                break;
                            case 3:
                                OuvrirModuleCommande();
                                Console.WriteLine("Que souhaitez-vous faire ?");
                                Console.WriteLine("\n1- Créer une nouvelle commande \n\n2- Afficher les commandes passées " +
                                    "\n\n3- Modifier une commande \n\n4- Afficher votre itinéraire pour une commande? (tapez 1, 2, 3 ou 4)");
                                int choix3 = Convert.ToInt32(Console.ReadLine());
                                if(choix3 == 1)
                                {
                                    Console.WriteLine("Création d'une nouvelle commande");
                                    Console.WriteLine("Quel est le nom du client pour lequel vous souhaitez passer commande ?");
                                    string nom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est le prénom du client pour lequel vous souhaitez passer commande ?");
                                    string prenom = Convert.ToString(Console.ReadLine());

                                    Client eh = ListeClients.Find(nom, prenom);
                                    if(eh == null)
                                    {
                                        Console.WriteLine("Le client recherché n'existe pas. Créons votre compte :\n");
                                        Console.WriteLine("Création d'un nouveau client \n");
                                        Console.WriteLine("Quel est votre numéro de sécurité social :");
                                        int id_ss = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quel est votre nom :");
                                        string nom1 = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre prénom :");
                                        string prenom1 = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre adresse mail :");
                                        string mail = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre adresse postale :");
                                        string adresse = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre ville de résidence ?");
                                        string ville = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre numéro de téléphone :");
                                        string num = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Quel est votre jour de naissance :");
                                        int jour1 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quel est votre mois de naissance :");
                                        int mois1 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quelle est votre année de naissance :");
                                        int annee1 = Convert.ToInt32(Console.ReadLine());
                                        DateTime date_naissance = new DateTime(annee1, mois1, jour1);
                                        eh = new Client(id_ss, nom1, prenom1, date_naissance, ville, adresse, mail, num);
                                        ListeClients.AjouterClient(eh);//ajout à la liste des clients
                                        Console.WriteLine("Bienvenue chez TransConnect, " + eh.Nom + " " + eh.Prenom);
                                    } //cas où le client recherché n'existe pas, on crée un nouveau client
                                    Console.WriteLine("\n Voici les villes où nous assurons la livraison : \n");
                                    foreach(Noeud1 n in listNoeuds)
                                    {
                                        Console.Write(n.Symbole + " ");
                                    }
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Quelle sera la ville de départ de votre commande ?");
                                    string villeDep = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quelle sera la ville d'arrivée de votre commande ?");
                                    string villeArr = Convert.ToString(Console.ReadLine());
                                    Noeud1 depart = listNoeuds.Find(n => n.Symbole == villeDep);
                                    Noeud1 arrivee = listNoeuds.Find(n => n.Symbole == villeArr);

                                    if (depart == null || arrivee == null)
                                    {
                                        Console.WriteLine("La ville de départ ou la ville d'arrivée n'existe pas.");
                                        return;
                                    }

                                    // Exécution de l'algorithme de Dijkstra à partir du graphe
                                    List<Etape> etapes = graphe.Dijkstra(depart, arrivee);

                                    float duree = graphe.CalculerDuree(etapes);//calcul de la durée de la livraison pour ainsi déterminer son prix
                                    /*
                                    Console.WriteLine("Quel jour souhaitez-vous recevoir votre commande :");
                                    int jour = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quel mois souhaitez-vous recevoir votre commande :");
                                    int mois = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quelle année souhaitez-vous recevoir votre commande :");
                                    int annee = Convert.ToInt32(Console.ReadLine());
                                    DateTime date_liv = new DateTime(annee, mois, jour);*/

                                    Commande c = new Commande(eh, villeDep, villeArr, duree); //commande créée
                                    ListeCommande.AjouterCommande(c); //commande ajoutée dans la liste des commandes

                                    Console.WriteLine(c.ToString());

                                    // Affichage du trajet
                                    Console.WriteLine("\nPlan de route du trajet pour le chauffeur pour aller : " + villeDep + " -> " + villeArr);
                                    graphe.AfficherResultatDijkstra(etapes, villeDep, villeArr);
                                    Console.WriteLine("Détails du trajet : \n");
                                    Console.WriteLine("Distance estimée : " + graphe.CalculerKM(etapes) + " km \n");
                                    Console.WriteLine("Durée estimée : " + graphe.ConvertirHeureMinute(graphe.CalculerDuree(etapes)) + "\n");
                                }
                                else if(choix3 == 2)
                                {
                                    ListeCommande.AfficherCommande();
                                }
                                else if(choix3 == 3)
                                {
                                    Console.WriteLine("Modification d'une commande");
                                    Console.WriteLine("Que souhaitez-vous faire ?");
                                    Console.WriteLine("1- Modifier la date de livraison \n2- Modifier la ville de départ " +
                                        "\n3- Modifier la ville d'arrivée ? (tapez 1, 2 ou 3)");
                                    int choixx = Convert.ToInt32(Console.ReadLine());
                                    if(choixx == 1)
                                    {
                                        Console.WriteLine("Modification de la date de livraison : \n");
                                        Console.WriteLine("Quel est votre numéro de commande ?");
                                        int r = Convert.ToInt32(Console.ReadLine());
                                        Commande c = ListeCommande.Find(r);

                                        Console.WriteLine("Quel jour souhaitez-vous recevoir votre commande :");
                                        int jour = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quel mois souhaitez-vous recevoir votre commande :");
                                        int mois = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quelle année souhaitez-vous recevoir votre commande :");
                                        int annee = Convert.ToInt32(Console.ReadLine());
                                        DateTime date_livn = new DateTime(annee, mois, jour);

                                        //Récupération des anciennes données de la commande pour créer une nouvelle commande
                                        int id = c.IdCom;
                                        Client a = c.A;
                                        string villeDep = c.VilleD;
                                        string villeArr = c.VilleA;
                                        //DateTime date = c.Date;
                                        Vehicule v = c.V;
                                        float duree = c.Duree;
                                        double prix = c.Prix;

                                        //il faut donc retirer une livraison au chauffeur précédent
                                        Salarie chauffeur = c.Chauffeur;
                                        chauffeur.Supp1Liv();
                                        //création de la nouvelle commande
                                        Commande no = new Commande(id,a, villeDep, villeArr, date_livn, duree, v, prix);
                                        ListeCommande.SupprimerCommande(c);
                                        ListeCommande.AjouterCommande(no);
                                        //suppression de l'ancienne commande et ajout de la nouvelle

                                        Console.WriteLine("Modification effectuée !");
                                        Console.WriteLine(no.ToString());
                                    }
                                    else if(choixx == 2)
                                    {
                                        Console.WriteLine("Modification de la ville de départ : \n");
                                        Console.WriteLine("Quel est votre numéro de commande ?");
                                        int r = Convert.ToInt32(Console.ReadLine());
                                        Commande c = ListeCommande.Find(r);

                                        Console.WriteLine("Quelle est votre nouvelle ville de départ :");
                                        string villeDep = Convert.ToString(Console.ReadLine());

                                        //Récupération des anciennes données de la commande pour créer une nouvelle commande
                                        int id = c.IdCom;
                                        Client a = c.A;
                                        string villeArr = c.VilleA;
                                        DateTime date = c.Date;
                                        Vehicule v = c.V;
                                        Salarie ch = c.Chauffeur;
                                        //calcul du nouveau temps du nouvel itinéraire
                                        Noeud1 depart = listNoeuds.Find(ne => ne.Symbole == villeDep);
                                        Noeud1 arrivee = listNoeuds.Find(ns => ns.Symbole == villeArr);

                                        if (depart == null || arrivee == null)
                                        {
                                            Console.WriteLine("La ville de départ ou la ville d'arrivée n'existe pas.");
                                            return;
                                        }

                                        // Exécution de l'algorithme de Dijkstra à partir du graphe
                                        List<Etape> etapes = graphe.Dijkstra(depart, arrivee); //on recalcule la durée du nouveau trajet

                                        float duree = graphe.CalculerDuree(etapes);
                                        Commande n = new Commande(id, a, villeDep, villeArr, date, duree, v, ch);
                                        ListeCommande.SupprimerCommande(c);
                                        ListeCommande.AjouterCommande(n); //création de la nouvelle commande
                                        

                                        Console.WriteLine("Modification effectuée !");

                                        Console.WriteLine(n.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Modification de la ville d'arrivée : \n");
                                        Console.WriteLine("Quel est votre numéro de commande ?");
                                        int r = Convert.ToInt32(Console.ReadLine());
                                        Commande c = ListeCommande.Find(r);

                                        Console.WriteLine("Quelle est votre nouvelle ville d'arrivée :");
                                        string villeArr = Convert.ToString(Console.ReadLine());

                                        //Récupération des anciennes données de la commande pour créer une nouvelle commande
                                        int id = c.IdCom;
                                        Client a = c.A;
                                        string villeDep = c.VilleD;
                                        DateTime date = c.Date;
                                        Vehicule v = c.V;
                                        Salarie ch = c.Chauffeur;
                                        //calcul du nouveau temps du nouvel itinéraire
                                        Noeud1 depart = listNoeuds.Find(nz => nz.Symbole == villeDep);
                                        Noeud1 arrivee = listNoeuds.Find(np => np.Symbole == villeArr);

                                        if (depart == null || arrivee == null)
                                        {
                                            Console.WriteLine("La ville de départ ou la ville d'arrivée n'existe pas.");
                                            return;
                                        }

                                        // Exécution de l'algorithme de Dijkstra à partir du graphe
                                        List<Etape> etapes = graphe.Dijkstra(depart, arrivee); //on recalcule la durée du nouveau trajet

                                        float duree = graphe.CalculerDuree(etapes);
                                        Commande n = new Commande(id, a, villeDep, villeArr, date, duree, v, ch);
                                        ListeCommande.SupprimerCommande(c);
                                        ListeCommande.AjouterCommande(n); //création de la nouvelle commande
                                        

                                        Console.WriteLine("Modification effectuée !");

                                        Console.WriteLine(n.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Affichage de votre itinéraire :");
                                    Console.WriteLine("\nQuel est votre numéro de commande ?");
                                    int re = Convert.ToInt32(Console.ReadLine());
                                    Commande c = ListeCommande.Find(re);
                                    string villeDepart = c.VilleD;
                                    string villeArrivee = c.VilleA;
                                    Noeud1 depart = listNoeuds.Find(n => n.Symbole == villeDepart);
                                    Noeud1 arrivee = listNoeuds.Find(n => n.Symbole == villeArrivee);

                                    if (depart == null || arrivee == null)
                                    {
                                        Console.WriteLine("La ville de départ ou la ville d'arrivée n'existe pas.");
                                        return;
                                    }

                                    Console.WriteLine("\nVotre itinéraire pour aller de :" + villeDepart + " -> " + villeArrivee + " est : ");
                                    // Exécution de l'algorithme de Dijkstra à partir du graphe
                                    List<Etape> etapes = graphe.Dijkstra(depart, arrivee);

                                    // Affichage du résultat
                                    graphe.AfficherResultatDijkstra(etapes, villeDepart, villeArrivee);
                                    Console.WriteLine("Détails du trajet : \n");
                                    Console.WriteLine("Distance estimée : " + graphe.CalculerKM(etapes) + " km \n");
                                    Console.WriteLine("Durée estimée : " + graphe.ConvertirHeureMinute(graphe.CalculerDuree(etapes)) + "\n");

                                }
                                break;
                            case 4:
                                OuvrirModuleStatistiques();
                                Console.WriteLine("Que souhaitez-vous faire ?");
                                Console.WriteLine("\n1- Afficher par chauffeur le nombre de livraisons effectuées \n\n2- Afficher les commandes selon une période temps " +
                                    "\n\n3- Afficher la moyenne des prix des commandes \n\n4- Afficher la moyenne des comptes clients? " +
                                    "\n\n5- Afficher la liste des commandes pour un client ?(tapez 1, 2, 3, 4 ou 5)");
                                int choix44 = Convert.ToInt32(Console.ReadLine());
                                if(choix44 == 1)
                                {
                                    Console.WriteLine("Affichage par chauffeur du nombre de livraisons effectuées : \n");
                                    Entreprise.AfficherLivraisonParChauffeur();
                                }
                                else if (choix44 == 2)
                                {
                                    Console.WriteLine("Affichage des commandes pour une période de temps donnée (entre 2 dates) : \n");
                                    Console.WriteLine("\nDate minimale : ");
                                    Console.WriteLine("Quel jour minimal souhaitez-vous (un entier, ex : 18, 19...) :");
                                    int jour11 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quel mois minimal souhaitez-vous (un entier, ex : 2, 10...)");
                                    int mois11 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quelle année minimale souhaitez-vous (un entier, ex : 2024, 2025...)");
                                    int annee11 = Convert.ToInt32(Console.ReadLine());
                                    DateTime date_min = new DateTime(annee11, mois11, jour11);

                                    Console.WriteLine("\nDate maximale : ");
                                    Console.WriteLine("Quel jour maximal souhaitez-vous (un entier, ex : 18, 19...) :");
                                    int jour22 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quel mois maximal souhaitez-vous (un entier, ex : 2, 10...)");
                                    int mois22 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Quelle année maximale souhaitez-vous (un entier, ex : 2024, 2025...)");
                                    int annee22 = Convert.ToInt32(Console.ReadLine());
                                    DateTime date_max = new DateTime(annee22, mois22, jour22);
                                    ListeCommande.TestFindAll(date_min, date_max);

                                }
                                else if (choix44 == 3)
                                {
                                    List<Commande> c1 = ListeCommande.ObtenirListeCommande();
                                    int nbCommande = c1.Count;
                                    Console.WriteLine("La moyenne des prix des commandes est : " + intercc.Moyenne() + " euros pour " + nbCommande + " commandes passées.");
                                }
                                else if (choix44 == 4)
                                {
                                    List<Client> c11 = ListeClients.ObtenirListeClients();
                                    int nbClient = c11.Count;
                                    Console.WriteLine("La moyenne des comptes clients est : " + interc.Moyenne() + " euros pour " + nbClient + " clients enregistrés sur le site.");
                                }
                                else
                                {
                                    Console.WriteLine("Affichage de la liste des commandes pour un client donné : \n");
                                    Console.WriteLine("\nQuel est le nom du client pour lequel vous souhaitez consulter l'historique ?");
                                    string nom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("\nQuel est le prénom du client pour lequel vous souhaitez consulter l'historique ?");
                                    string prenom = Convert.ToString(Console.ReadLine());

                                    Client eh1 = ListeClients.Find(nom, prenom);
                                    ListeCommande.AfficherCommandePourUnClient(eh1);
                                }
                                break;
                            case 5:
                                OuvrirModuleAutre();
                                Console.WriteLine("\n1- Afficher le CA de l'entreprise \n\n2- Afficher les livraisons à venir pour un chauffeur " +
                                   "\n\n3- Ajouter une ville  \n\n4- Ajouter une nouvelle connexion entre 2 villes ? (tapez 1, 2, 3 ou 4)");
                                int nchoix = Convert.ToInt32(Console.ReadLine());
                                if(nchoix == 1)
                                {
                                    Console.WriteLine("Le chiffre d'affaire de l'entreprise est : " + interc.Somme() + " euros brut.");
                                    Console.WriteLine("Bravo à toute l'équipe !");
                                }
                                else if (nchoix == 2)
                                {
                                    Console.WriteLine("Quel est votre nom ?");
                                    string nom = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Quel est votre prénom ?");
                                    string prenom = Convert.ToString(Console.ReadLine());
                                    Salarie recherche = Entreprise.Find(nom, prenom);
                                    if(recherche.Poste == "Chauffeur")
                                    {
                                        ListeCommande.TestFindAll1(recherche);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Le salarié renvoyé est " + recherche.Poste + " et donc pas un chauffeur.");
                                    }
                                }
                                else if (nchoix == 3)
                                {
                                    Console.WriteLine("Ajouter une ville que nous désservirons : ");
                                    Console.WriteLine("\n Voici les villes où nous assurons actuellement la livraison : \n");
                                    foreach (Noeud1 n in listNoeuds)
                                    {
                                        Console.Write(n.Symbole + " ");
                                    }
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Quel est le nom de la ville que vous souhaitez ajouter ?");
                                    string ville = Convert.ToString(Console.ReadLine());
                                    Noeud1 na = new Noeud1(ville);
                                    Console.WriteLine("Vous souhaitez connecter cette ville à combien d'autres ville ? (1 ou plusieurs :)");
                                    int nb = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < nb; i++)
                                    {

                                        Console.WriteLine("Avec quelle ville souhaitez-vous faire la connexion " + i + " ?");
                                        Console.WriteLine("\n Voici les villes où nous assurons actuellement la livraison : \n");
                                        foreach (Noeud1 n in listNoeuds)
                                        {
                                            Console.Write(n.Symbole + " ");
                                        }
                                        Console.WriteLine("\n");
                                        string ville1 = Convert.ToString(Console.ReadLine());
                                        Noeud1 test = listNoeuds.Find(x => x.Symbole == ville1);
                                        if(test != null)
                                        {
                                            Console.WriteLine("Quelle distance doit séparer les deux villes ?");
                                            int km = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Quelle durée doit-on mettre pour aller d'une ville à l'autre (sous la forme 2,5 pour 2h30) ?");
                                            float dur = Convert.ToSingle(Console.ReadLine());
                                            float duree = (float)dur;
                                            na.AjouterArrivant(km, duree, test);
                                            test.AjouterArrivant(km, duree, na);
                                            
                                        }
                                        
                                        else
                                        {
                                            Console.WriteLine("La ville recherchée n'existe pas.");
                                        }
                                    }
                                    listNoeuds.Add(na);
                                    Console.WriteLine("Ville ajoutée !");
                                }
                                else
                                {
                                    Console.WriteLine("Ajouter une nouvelle connexion entre 2 villes : ");
                                    Console.WriteLine("\n Voici les villes où nous assurons actuellement la livraison : \n");
                                    foreach (Noeud1 n in listNoeuds)
                                    {
                                        Console.Write(n.Symbole + " ");
                                    }
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Quel est le nom de la première ville dont vous voulez réaliser une nouvelle connexion ?");
                                    string ville1 = Convert.ToString(Console.ReadLine());
                                    Noeud1 test1 = listNoeuds.Find(x => x.Symbole == ville1);
                                    Console.WriteLine("Quel est le nom de la deuxième ville dont vous voulez réaliser une nouvelle connexion ?");
                                    string ville2 = Convert.ToString(Console.ReadLine());
                                    Noeud1 test2 = listNoeuds.Find(x => x.Symbole == ville2);
                                    if (test1 != null && test2 != null)
                                    {
                                        Console.WriteLine("Quelle distance doit séparer les deux villes ?");
                                        int km = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Quelle durée doit-on mettre pour aller d'une ville à l'autre (sous la forme 2,5 pour 2h30) ?");
                                        float dur = Convert.ToSingle(Console.ReadLine());
                                        float duree = (float)dur;
                                        test1.AjouterArrivant(km, duree, test2);
                                        test2.AjouterArrivant(km, duree, test1);
                                        Console.WriteLine("Itinéraire ajouté !");
                                    }

                                    else
                                    {
                                        Console.WriteLine("L'une des villes recherchées n'existe pas.");
                                    }
                                    
                                }
                                break;
                            default:
                                Console.WriteLine("Choix invalide !");
                                break;
                        }
                        Console.WriteLine("Appuyez sur ESPACE pour retourner à la page de connexion...");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            retourPageAccueil = true;
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    // Identifiants incorrects
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Identifiants incorrects. Veuillez réessayer.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

        }

        static string GetPasswordInput() //mettre des étoiles à la place des lettres pour le mdp
        {
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Ignore les touches spéciales comme Enter
                if (!char.IsControl(key.KeyChar))
                {
                    Console.Write("*");
                    password += key.KeyChar;
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    // Retire le dernier caractère si l'utilisateur appuie sur Backspace
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b"); // Efface le caractère précédent
                }
            } while (key.Key != ConsoleKey.Enter);

            return password;
        }

        //les méthodes suivantes sont appelées lors de l'affichage d'une nouvelle page
        public static void AfficherPageAccueil()
        {
            Console.WriteLine("Bienvenue sur la page d'accueil !");
        }

        static void OuvrirModuleClient()
        {
            Console.Clear();
            Console.WriteLine("Module Client ouvert.");
        }
        static void OuvrirModuleSalarie()
        {
            Console.Clear();
            Console.WriteLine("Module Salariés ouvert.");
        }
        static void OuvrirModuleCommande()
        {
            Console.Clear();
            Console.WriteLine("Module Commande ouvert.");
        }
        static void OuvrirModuleStatistiques()
        {
            Console.Clear();
            Console.WriteLine("Module Statistiques ouvert.");
        }
        static void OuvrirModuleAutre()
        {
            Console.Clear();
            Console.WriteLine("Module Autre ouvert.");
        }
        
        
    }
}
