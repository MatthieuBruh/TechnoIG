==============================
GENERAL
==============================
D'origine, la base de données utilisée est en XE.
Il existe deux comptes qui sé génèrent avec le script :
	- (utilisateur => mot de passe)
	- TechnoIG_data => TechnoIG_data
	- TechnoIG_user => TechnoIG_user

Le compte TechnoIG_data a les tables, les vues, les packages, triggers.
Le compte TechnoIG_user a accès aux vues et aux packages de TechnoIG_data.

Les vues ne prennent pas de paramètres car lorsque j'ai essayé,
ces derniers n'étaients pas pris en compte.
De ce fait, je les ai enlevés.

Le dossier Tests contient les tests des contraintes et des packages.


==============================
COHERENCES DES DONNÉES
==============================
/!\ ATTENTION : Les valeurs sont des valeurs de tests.
De ce fait, certains champs ne sont pas cohérents.
Les champs concernés sont :
	TEC_LIGNE_COM_FOU.LIG_PRIX <=!=> TEC_PRODUIT.PR_PRIX_ACHAT
	TEC_LIGNE_COM_CLI.LIG_PRIX <=!=> TEC_PRODUIT.PR_PRIX_VENTE
	TEC_BON.BON_TAUX <=!=> TEC_CLIENT.CLI_NOMBRE_POINTS


==============================
Code erreurs :
==============================
Les codes erreurs sont gérées comme suivant dans les packages.

20000 à 20009 => Gestion des commandes clients
20010 à 20019 => Gestion des clients
20020 à 20029 => Gestion du personnel
20030 à 20039 => Gestion des bons clients
20040 à 20049 => Gestion des commandes fournisseurs
20050 à 20059 => Erreurs de connexion (compte utilisateur)


==============================
Attribution des bons clients :
==============================
L'application est configurée pour que les clients obtiennent des bons aux étapes suivantes :
Lorsque le client dépasse
	- 200 pts 	: 	ajout d'un rabais de 1% pour le client
	- 400 pts 	: 	ajout d'un rabais de 2% pour le client
	- 600 pts 	: 	ajout d'un rabais de 3% pour le client
	- 800 pts 	: 	ajout d'un rabais de 4% pour le client
	- 1000 pts 	:	ajout d'un rabais de 5% pour le client
Arrivé à 1000 points, le score du client est rediminué de 1000.

