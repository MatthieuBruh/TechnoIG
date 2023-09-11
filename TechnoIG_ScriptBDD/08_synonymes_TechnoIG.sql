-- ====================================================================
-- Script : 08_synonymes_TechnoIG.sql
-- Objet  : Création des synonymes TechnoIG
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- 1.0      MB   14.05.2022  TERMINÉ
-- ====================================================================

-- ====================================================
-- Création des SYNONYMES pour les vues
-- ====================================================

CREATE OR REPLACE SYNONYM TechnoIG_user.vw_recherche_produits FOR TechnoIG_data.vw_recherche_produits;

CREATE OR REPLACE SYNONYM TechnoIG_user.vw_recherche_clients FOR TechnoIG_data.vw_recherche_clients;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_recherche_bons_clients FOR TechnoIG_data.vw_recherche_bons_clients;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_creer_modifier_client FOR TechnoIG_data.vw_creer_modifier_client;

CREATE OR REPLACE SYNONYM TechnoIG_user.vw_produits_limites FOR TechnoIG_data.vw_produits_limites;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_historique_commandes FOR TechnoIG_data.vw_historique_commandes;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_liste_fournisseurs FOR TechnoIG_data.vw_liste_fournisseurs;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_statistiques_fournisseurs FOR TechnoIG_data.vw_statistiques_fournisseurs;

CREATE OR REPLACE SYNONYM TechnoIG_user.vw_liste_personnels FOR TechnoIG_data.vw_liste_personnels;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_statistiques_employes FOR TechnoIG_data.vw_statistiques_employes;

CREATE OR REPLACE SYNONYM TechnoIG_user.vw_personnel_details FOR TechnoIG_data.vw_personnel_details;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_personnel_commandes FOR TechnoIG_data.vw_personnel_commandes;
CREATE OR REPLACE SYNONYM TechnoIG_user.vw_creer_modifier_personnel FOR TechnoIG_data.vw_creer_modifier_personnel;

CREATE OR REPLACE SYNONYM TechnoIG_user.VW_MARQUES FOR TechnoIG_data.VW_MARQUES;
CREATE OR REPLACE SYNONYM TechnoIG_user.VW_CATEGORIE FOR TechnoIG_data.VW_CATEGORIE;
CREATE OR REPLACE SYNONYM TechnoIG_user.VW_NPA_Clients FOR TechnoIG_data.VW_NPA_Clients;
CREATE OR REPLACE SYNONYM TechnoIG_user.VW_FOURNISSEUR FOR TechnoIG_data.VW_FOURNISSEUR;


-- ====================================================
-- Création des SYNONYMES pour les packages
-- ====================================================
CREATE OR REPLACE SYNONYM TechnoIG_user.pkg_gestionCmdClients FOR TechnoIG_data.pkg_gestionCmdClients;
CREATE OR REPLACE SYNONYM TechnoIG_user.pkg_gestionCmdFournisseur FOR TechnoIG_data.pkg_gestionCmdFournisseur;

CREATE OR REPLACE SYNONYM TechnoIG_user.pkg_gestionPersonnel FOR TechnoIG_data.pkg_gestionPersonnel;
CREATE OR REPLACE SYNONYM TechnoIG_user.pkg_gestionClient FOR TechnoIG_data.pkg_gestionClient;


-- ====================================================
-- Créations des SYNONYMES pour les sequences
-- ====================================================

CREATE OR REPLACE SYNONYM TechnoIG_user.sq_tec_commandes_clients FOR TechnoIG_data.sq_tec_commandes_clients;
CREATE OR REPLACE SYNONYM TechnoIG_user.sq_tec_commandes_fournisseurs FOR TechnoIG_data.sq_tec_commandes_fournisseurs;
CREATE OR REPLACE SYNONYM TechnoIG_user.sq_tec_clients FOR TechnoIG_data.sq_tec_clients;
CREATE OR REPLACE SYNONYM TechnoIG_user.sq_tec_bon FOR TechnoIG_data.sq_tec_bon;
CREATE OR REPLACE SYNONYM TechnoIG_user.sq_tec_personnel FOR TechnoIG_data.sq_tec_personnel;