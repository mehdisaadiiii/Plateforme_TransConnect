# Plateforme TransConnect

Application console de gestion pour **TransConnect** : clients, commandes, salariés, organigramme et calcul d’itinéraires (graphe, Dijkstra).

**Auteurs :** Maël RUFFENACH, Mehdi SAADI

---

## Description

TransConnect est une plateforme de gestion qui permet à un utilisateur authentifié (M. Dupont) de :

- **Gérer les clients** : liste, tri, filtrage par ville, statuts (Bronze, Argent, Or)
- **Gérer les commandes** : création, consultation, modification, calcul de prix et de durée via un graphe (Dijkstra)
- **Gérer les salariés** : liste, moyennes, organigramme (arbre n-aire)
- **Consulter l’organigramme** de l’entreprise

L’application repose sur une **page de connexion** (réutilisation du projet BelleFleur) puis un **menu principal** avec des sous-menus par module.

---

## Connexion

- **Email :** `eric.dupont@transconnect.fr`
- **Mot de passe :** `Esilv`

Le mot de passe est masqué par des étoiles à la saisie.

---

## Structure du projet

- **Projet principal :** `Projet_TransConnect_RUFFENACH_SAADI/` — application console .NET Framework 4.7.2
- **Tests unitaires :** `testunitaire/` — projet de tests (netcoreapp3.1)
- **Rapport :** `RAPPORT - TRANSCONNECT.pdf`
- **UML :** `UML.pdf`, `UML.png`, `UML_TRANSCONNECT.mdj`

### Principales classes

| Domaine      | Classes principales                                      |
|-------------|----------------------------------------------------------|
| Clients     | `Client`, `ListeClients`, `ClientInterface`              |
| Commandes   | `Commande`, `ListeCommande`, `CommandeInterFace`         |
| Salariés    | `Salarie`, `Entreprise`, `ListeSCE`, `SalarieInterface`  |
| Organigramme| `Arbre`, `Noeud` (n-aire)                                |
| Graphe      | `Graphe`, `Noeud1`, `Lien`, `Etape` (Dijkstra)           |
| Véhicules   | `Vehicule`                                               |

---

## Prérequis

- **.NET Framework 4.7.2** (ou version compatible)
- Visual Studio 2019+ ou outil en ligne de commande MSBuild

---

## Compilation et exécution

### Visual Studio

1. Ouvrir `Projet_TransConnect_RUFFENACH_SAADI.sln`
2. Choisir le projet **Projet_TransConnect_RUFFENACH_SAADI** comme projet de démarrage
3. Lancer avec F5 (Debug) ou Ctrl+F5 (sans débogage)

### Ligne de commande (MSBuild)

```bash
msbuild Projet_TransConnect_RUFFENACH_SAADI.sln -p:Configuration=Debug
./Projet_TransConnect_RUFFENACH_SAADI/bin/Debug/Projet_TransConnect_RUFFENACH_SAADI.exe
```

---

## Tests unitaires

Les tests se trouvent dans le projet **testunitaire** (référence au projet principal). Exécution selon votre environnement (Test Explorer dans Visual Studio ou `dotnet test` si le projet est configuré en .NET Core).

---

## Licence

Projet académique — usage selon les règles de l’établissement.
