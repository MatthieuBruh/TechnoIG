-- ====================================================================
-- Script : 05_vues_sequences_TechnoIG.sql
-- Objet  : Création et suppression des vues TechnoIG
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- 1.5      MB   03.05.2022  TERMINÉ
-- ====================================================================

-- ====================================================
-- Création des VUES
-- ====================================================


-- Produits

-- ====================================================
-- Vue des produits, de la marque et de la catégorie
-- ====================================================

CREATE OR REPLACE VIEW vw_recherche_produits (produitId, nom, marque, categorie, prix_vente_unitaire, stock) AS
SELECT pro_no, PRO_NOM, MAR_NOM, CAT_NOM, PRO_PRIX_VENTE, PRO_STOCK
FROM TEC_PRODUIT
JOIN TEC_MARQUE ON MAR_NO = PRO_MAR_NO
JOIN TEC_CATEGORIE ON CAT_NO = PRO_CAT_NO
order by pro_no;

GRANT SELECT, UPDATE ON vw_recherche_produits TO TechnoIG_user;



-- Clients

-- ====================================================
-- Vue des clients et des bons
-- ====================================================

CREATE OR REPLACE VIEW vw_recherche_clients (clientID, nom, prenom, sexe, noRue, nomRue, npa, localite, pays) AS
SELECT cli_no, cli_nom, cli_prenom, cli_sexe, cli_no_rue, cli_nom_rue, cli_npa, cli_nom_localite, cli_pays
FROM TEC_CLIENT
order by cli_no;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_recherche_clients TO TechnoIG_user;



-- ====================================================
-- Vue pour les bons
-- ====================================================

CREATE OR REPLACE VIEW vw_recherche_bons_clients (bonID, clientID, taux) AS
SELECT bon_no, bon_cli_no, bon_taux
FROM TEC_BON
WHERE BON_NO_COMMANDE IS NULL
order by bon_no;

GRANT SELECT ON vw_recherche_bons_clients TO TechnoIG_user;



-- ====================================================
-- Vue pour la création et modification des clients
-- ====================================================

CREATE OR REPLACE VIEW vw_creer_modifier_client(id, nom, prenom, sexe, noRue, nomRue, npa, localite, pays) AS
SELECT cli_no, cli_nom, cli_prenom, cli_sexe, cli_no_rue, cli_nom_rue, cli_npa, cli_nom_localite, cli_pays
FROM TEC_CLIENT
order by cli_no;

GRANT SELECT, INSERT, UPDATE ON vw_creer_modifier_client TO TechnoIG_user;




-- Fournisseurs

-- ====================================================
-- Vue pour les produits en quantités limités
-- ====================================================

CREATE OR REPLACE VIEW vw_produits_limites(Fournisseur, ProduitID, Produit, Marque, Categorie, PrixAchat, SeuilStock, StockRestant, LotParCommande) AS
SELECT fou_nom, pro_no, pro_nom, mar_nom, cat_nom, pro_prix_achat, pro_seuil, pro_stock, pro_lot
FROM TEC_PRODUIT
JOIN TEC_MARQUE ON MAR_NO = PRO_MAR_NO
JOIN TEC_CATEGORIE ON CAT_NO = PRO_CAT_NO
JOIN TEC_FOURNISSEUR ON FOU_NO = PRO_FOU_NO
WHERE pro_stock <= pro_seuil
order by fou_nom;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_produits_limites TO TechnoIG_user;



-- ====================================================
-- Vue pour les historiques des commandes
-- ====================================================

CREATE OR REPLACE VIEW vw_historique_commandes (Numero, Fournisseur, Produit, Marque, Categorie, PrixAchat, Quantite, Total) AS
SELECT com_no, fou_nom, pro_nom, mar_nom, cat_nom, lig_prix, lig_nombre, (lig_prix * lig_nombre)
FROM TEC_COMMANDE_FOU
JOIN TEC_LIGNE_COM_FOU ON com_no = lig_com_no
JOIN TEC_PRODUIT ON pro_no = lig_pro_no
JOIN TEC_MARQUE ON mar_no = pro_mar_no
JOIN TEC_CATEGORIE ON cat_no = pro_cat_no
JOIN TEC_FOURNISSEUR ON fou_no = pro_fou_no
ORDER BY com_no;

GRANT SELECT ON vw_historique_commandes TO TechnoIG_user;



-- ====================================================
-- Vue pour la liste des fournisseurs
-- ====================================================

CREATE OR REPLACE VIEW VW_LISTE_FOURNISSEURS (nom, email, referant, addresse, npa, pays, nombredeproduits) AS
SELECT fou_nom, fou_email, fou_nom_referant, fou_no_rue || ', ' || fou_nom_rue, fou_npa, fou_pays, COUNT(pro_Fou_no) FROM tec_commande_fou
JOIN TEC_LIGNE_COM_FOU on COM_NO = LIG_COM_NO
JOIN tec_produit ON lig_pro_no = pro_no
JOIN tec_fournisseur ON pro_fou_no = fou_no
GROUP BY fou_nom, fou_email, fou_nom_referant, fou_nom_rue, fou_no_rue, fou_npa, fou_pays
order by fou_nom;

GRANT SELECT ON vw_liste_fournisseurs TO TechnoIG_user;



-- ====================================================
-- Vue pour les statistiques des fournisseurs
-- ====================================================

CREATE OR REPLACE VIEW vw_statistiques_fournisseurs (Nom, Mois, nbCommandes) AS
SELECT fou_nom, TO_CHAR(TO_DATE(EXTRACT(month FROM TRUNC(com_date)), 'MM'), 'MONTH') || ' ' || EXTRACT(YEAR FROM TRUNC(com_date)) "Periode", COUNT(*)
FROM tec_commande_fou
JOIN tec_ligne_com_fou ON com_no = lig_com_no
JOIN tec_produit ON lig_pro_no = pro_no
JOIN tec_fournisseur ON pro_fou_no = fou_no
GROUP BY TRUNC(com_date), fou_nom
ORDER BY TRUNC(com_date);

GRANT SELECT ON vw_statistiques_fournisseurs TO TechnoIG_user;




-- Magasin

-- ====================================================
-- Vue pour afficher les employés
-- ====================================================

CREATE OR REPLACE VIEW vw_liste_personnels (Numero, Nom, Prenom, Fonction, Total) AS
SELECT per_no, per_nom, per_prenom, niv_nom, COUNT(com_no)
FROM TEC_PERSONNEL
LEFT JOIN TEC_NIVEAU_HIERARCHIQUE ON per_niv_no = niv_no
LEFT JOIN TEC_COMMANDE_CLI ON per_no = com_per_no
WHERE per_is_active = 1
GROUP BY per_no, per_nom, per_prenom, niv_nom
ORDER BY per_no;

GRANT SELECT ON vw_liste_personnels TO TechnoIG_user;



-- ====================================================
-- Vue pour les statistiques des employés
-- ====================================================

CREATE OR REPLACE VIEW vw_statistiques_employes (Numero, Nom, Mois, nbCommandes) AS
SELECT per_no, UPPER(per_nom) || ' ' || per_prenom, TO_CHAR(TO_DATE(EXTRACT(month FROM TRUNC(com_date)), 'MM'), 'MONTH') || ' ' || EXTRACT(YEAR FROM TRUNC(com_date)) "Periode", COUNT(*)
FROM tec_commande_cli
JOIN tec_personnel ON com_per_no = per_no
GROUP BY TRUNC(com_date), per_no, per_nom, per_prenom
ORDER BY per_no, TRUNC(com_date);

GRANT SELECT ON vw_statistiques_employes TO TechnoIG_user;



-- Profil

-- ====================================================
-- Vue pour les profils utilisateurs
-- ====================================================

CREATE OR REPLACE VIEW vw_personnel_details (Numero, Username, Nom, Prenom, NiveauHierarchique) AS
SELECT per_no, per_nom_utilisateur, per_nom, per_prenom, niv_nom
FROM tec_personnel
JOIN tec_niveau_hierarchique ON per_niv_no = niv_no
order by per_no;

GRANT SELECT ON vw_personnel_details TO TechnoIG_user;



-- ====================================================
-- Vue pour les commandes d'un employés
-- ====================================================

CREATE OR REPLACE VIEW vw_personnel_commandes (vendeur, dateCommande, nomClient, prenomClient, numeroCommande, bonCommande, toal) AS
SELECT per_nom_utilisateur, com_date, cli_nom, cli_prenom, com_no, bon_taux,  CASE 
       WHEN bon_taux IS NOT NULL THEN SUM(lig_nombre * lig_prix) * bon_taux
       ELSE SUM(lig_nombre * lig_prix)
       END "Total"
FROM TEC_PERSONNEL
LEFT JOIN TEC_COMMANDE_CLI ON PER_NO = COM_PER_NO
LEFT JOIN TEC_LIGNE_COM_CLI ON com_no = lig_com_no
JOIN TEC_CLIENT ON cli_no = com_cli_no
LEFT JOIN TEC_BON ON bon_no_commande = com_no
GROUP BY com_no, per_nom_utilisateur, com_date, cli_nom, cli_prenom, bon_taux
ORDER BY per_nom_utilisateur, com_no;

GRANT SELECT ON vw_personnel_commandes TO TechnoIG_user;



-- ====================================================
-- Vue pour la création et modification d'un compte
-- ====================================================

CREATE OR REPLACE VIEW vw_creer_modifier_personnel (Nom, Prenom, Utilisateur, Fonction, MotDePasse) AS
SELECT per_nom, per_prenom, per_nom_utilisateur, niv_nom, per_password
FROM tec_personnel
JOIN tec_niveau_hierarchique ON per_niv_no = niv_no;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_creer_modifier_personnel TO TechnoIG_user;



-- ====================================================
-- Vues pour les filtres
-- ====================================================

CREATE OR REPLACE VIEW VW_MARQUES(Nom) AS
SELECT DISTINCT mar_nom FROM TEC_MARQUE ORDER BY mar_nom;

GRANT SELECT ON VW_MARQUES TO TechnoIG_user;



CREATE OR REPLACE VIEW VW_CATEGORIE(Nom) AS
SELECT DISTINCT cat_nom FROM TEC_CATEGORIE ORDER BY cat_nom;

GRANT SELECT ON VW_CATEGORIE TO TechnoIG_user;



CREATE OR REPLACE VIEW VW_NPA_Clients(Npa) AS
SELECT DISTINCT cli_npa FROM TEC_CLIENT ORDER BY cli_npa;

GRANT SELECT ON VW_NPA_Clients TO TechnoIG_user;



CREATE OR REPLACE VIEW VW_FOURNISSEUR(Nom) AS
SELECT DISTINCT fou_nom FROM TEC_FOURNISSEUR ORDER BY fou_nom;

GRANT SELECT ON VW_FOURNISSEUR TO TechnoIG_user;



-- ====================================================
-- Création des SEQUENCES
-- ====================================================


-- Commandes clients

DROP SEQUENCE sq_tec_commandes_clients;

CREATE SEQUENCE sq_tec_commandes_clients START WITH 100 INCREMENT BY 1;


-- Commandes fournisseurs

DROP SEQUENCE sq_tec_commandes_fournisseurs;

CREATE SEQUENCE sq_tec_commandes_fournisseurs START WITH 100 INCREMENT BY 1;


-- Clients

DROP SEQUENCE sq_tec_clients;

CREATE SEQUENCE sq_tec_clients START WITH 100 INCREMENT BY 1;


-- Bon clients

DROP SEQUENCE sq_tec_bon;

CREATE SEQUENCE sq_tec_bon START WITH 100 INCREMENT BY 1;


-- Personnel

DROP SEQUENCE sq_tec_personnel;

CREATE SEQUENCE sq_tec_personnel START WITH 100 INCREMENT BY 1;