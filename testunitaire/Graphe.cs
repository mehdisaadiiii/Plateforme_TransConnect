using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class Graphe //classe qui construira l'itinéraire grâce à Dijkstra et qui affichera également le graphe
    {
        List<Noeud1> listNoeuds = new List<Noeud1>();

        public Graphe(List<Noeud1> listNoeuds)
        {
            this.listNoeuds = listNoeuds;
        }

        public override string ToString()
        {
            string s = "Les noeuds du graphe avec leurs adjacents sont : \n";
            foreach(Noeud1 n in listNoeuds)
            {
                s += n + "\n";
            }

            return s;
        }

        public Noeud1 TrouverOuCreerNoeud(string symbole)
        {
            foreach (Noeud1 noeud in listNoeuds)
            {
                if (noeud.Symbole == symbole)
                {
                    return noeud;
                }
            }
            Noeud1 nouveau = new Noeud1(symbole);
            listNoeuds.Add(nouveau);
            return nouveau;
        }

        //Partie Algorithme de Dijkstra

        //Méthode permettant de chercher tous les noeuds adjacents à partir d'un noeud courant dans une étape du calcul de D.
        //+ ajouter à chaque noeud adjacent un chemin arrivant vers lui

        public void CalculDetails(Etape etape)
        {
            foreach(Lien l in etape.Lien.NoeudDepart.GetAdjacents())
            {
                l.GetNoeudDepart().AjouterArrivant(etape.Km + l.Km, etape.Duree + l.Duree, etape.Lien.NoeudDepart);
            }
        }

        //La méthode suivante est utilisée pour trouver la réponse finale en cherchant le plus court chemin avec un
        //parcours dans le sens inverse de la liste d'étapes trouvé en partant de la dernière étape

        public Etape ChercherPrecedent(Noeud1 noeud, List<Etape> list)
        {
            foreach(Etape e in list)
            {
                if(e.Lien.NoeudDepart == noeud)
                {
                    return e;
                }
            }
            return null;
        }

        //Algorithme de Dijkstra
        public List<Etape> AfficherGraphe(Noeud1 depart)
        {
            List<Etape> listEtapes = new List<Etape>();
            List<Noeud1> listNoeudsNonTraites = new List<Noeud1>();

            //Initialisation de l'algorithme
            foreach (Noeud1 n in listNoeuds)
            {
                n.Traite = false;
                if (n == depart)
                {
                    n.Distance = 0;
                }
                else
                {
                    n.Distance = int.MaxValue;
                }
                n.Precedent = null;
                listNoeudsNonTraites.Add(n);
            }

            while (listNoeudsNonTraites.Count > 0)
            {
                Noeud1 u = null;
                int minDistance = int.MaxValue; //initialisé à l'infini
                foreach (Noeud1 noeud in listNoeudsNonTraites)
                {
                    if (!noeud.Traite && noeud.Distance < minDistance)
                    {
                        u = noeud;
                        minDistance = noeud.Distance;
                    }
                }

                if (u == null)
                {
                    break; //aucun noeud non traité trouvé, donc on termine l'algo
                }

                // Mettez à jour l'état de traite de u avant de le retirer de la liste des noeuds non traités
                u.Traite = true;

                //Parcours des noeuds adjacents à u
                foreach (Lien l in u.GetAdjacents())
                {
                    Noeud1 v = l.GetNoeudDepart();
                    if (!v.Traite)
                    {
                        int tempDistance = u.Distance + l.Km; //distance provisoire
                        if (tempDistance < v.Distance)
                        {
                            v.Distance = tempDistance;
                            v.Precedent = u;
                        }
                    }
                }
            }

            //Création de la liste d'étapes
            //Création de la liste d'étapes
            foreach (Noeud1 n in listNoeuds)
            {
                if (n.Precedent != null)
                {
                    foreach (Lien l in n.Precedent.GetAdjacents())
                    {
                        if (l.GetNoeudDepart() == n)
                        {
                            listEtapes.Add(new Etape(n.Distance, l.Duree, n.Precedent, l));
                            break;
                        }
                    }
                }
            }


            return listEtapes;
        }

        public List<Etape> Dijkstra(Noeud1 depart, Noeud1 arrivee) //retourne une étape sous la forme : villeA -> villeB
        {
            List<Etape> listEtapes = new List<Etape>();
            List<Noeud1> listNoeudsNonTraites = new List<Noeud1>();

            // Initialisation de l'algorithme
            foreach (Noeud1 n in listNoeuds)
            {
                n.Traite = false;
                if (n == depart)
                {
                    n.Distance = 0;
                }
                else
                {
                    n.Distance = int.MaxValue;
                }
                n.Precedent = null;
                listNoeudsNonTraites.Add(n);
            }

            while (listNoeudsNonTraites.Count > 0)
            {
                Noeud1 u = null;
                int minDistance = int.MaxValue; //initialisé à l'infini
                foreach (Noeud1 noeud in listNoeudsNonTraites)
                {
                    if (!noeud.Traite && noeud.Distance < minDistance)
                    {
                        u = noeud;
                        minDistance = noeud.Distance;
                    }
                }

                if (u == null)
                {
                    break; // aucun noeud non traité trouvé, donc on termine l'algo
                }

                // On met à jour l'état de traité de u avant de le retirer de la liste des noeuds non traités
                u.Traite = true;

                // Si on atteint le noeud d'arrivée, arrêter l'algorithme
                if (u == arrivee)
                {
                    break;
                }

                // Parcours des noeuds adjacents à u
                foreach (Lien l in u.GetAdjacents())
                {
                    Noeud1 v = l.GetNoeudDepart();
                    if (!v.Traite)
                    {
                        int tempDistance = u.Distance + l.Km; // distance provisoire
                        if (tempDistance < v.Distance)
                        {
                            v.Distance = tempDistance;
                            v.Precedent = u;
                        }
                    }
                }
            }

            // Reconstruction du chemin entre le noeud de départ et le noeud d'arrivée
            Noeud1 noeudActuel = arrivee;
            while (noeudActuel != null)
            {
                if (noeudActuel.Precedent != null)
                {
                    foreach (Lien l in noeudActuel.Precedent.GetAdjacents())
                    {
                        if (l.GetNoeudDepart() == noeudActuel)
                        {
                            listEtapes.Add(new Etape(noeudActuel.Distance, l.Duree, noeudActuel.Precedent, l));
                            break;
                        }
                    }
                }
                noeudActuel = noeudActuel.Precedent;
            }

            listEtapes.Reverse(); // Inverser la liste d'étapes pour obtenir l'ordre correct

            return listEtapes;
        }

        public void AfficherResultatDijkstra(List<Etape> etapes, string villeDepart, string villeArrivee)
        {
            if (etapes.Count == 0)
            {
                Console.WriteLine("Aucun chemin trouvé !");
                return;
            }
            Console.WriteLine("Chemin optimal trouvé :");

            // Affiche les étapes suivantes
            for (int i = 0; i < etapes.Count; i++)
            {
                Etape etape = etapes[i];
                Console.WriteLine($"{etape.Precedent.Symbole} -> {etape.Lien.NoeudDepart.Symbole}");
            }
        }

        public int CalculerKM(List<Etape> etapes) //renvoie la distance totale à parcourir
        {
            int somme = 0;
            for (int i = 0; i < etapes.Count; i++)
            {
                somme += etapes[i].Km;
            }
            return somme;
        }

        public float CalculerDuree(List<Etape> etapes) //renvoie la durée du trajet
        {
            float somme = 0f;
            for (int i = 0; i < etapes.Count; i++)
            {
                somme += etapes[i].Duree;
            }
            return somme;
        }

        public string ConvertirHeureMinute(float duree) //afficher correctement la durée du trajet
        {
            int heures = (int)duree; // Extraire la partie entière pour les heures
            int minutes = (int)((duree - heures) * 60); // Convertir la partie décimale en minutes

            return $"{heures} heures et {minutes} minutes";
        }

    }
}
