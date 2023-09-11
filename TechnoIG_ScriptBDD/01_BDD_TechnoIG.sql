-- ====================================================================
-- Script : 01_TechnoIG.sql
-- Objet  : Création BDD TechnoIG sur SGBD Oracle (XE) 
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- BETA	    MB   09.05.2022  En cours de développement
-- ====================================================================


SET ECHO ON
SET LINESIZE 200
SET PAGESIZE 60


-- Création des utilisateurs en tant que System
SPOOL .\Logs\02_utilisateurs_TechnoIG.log
@.\02_utilisateurs_TechnoIG.sql
SPOOL OFF

-- Connexion à XE en tant que TechnoIG_data (propirétaires des objets de schéma)
CONNECT TechnoIG_data/TechnoIG_data@XE

-- Création des tables
SPOOL .\Logs\03_tables_TechnoIG.log
@.\03_tables_TechnoIG.sql
SPOOL OFF

-- Chargement des données
SPOOL .\Logs\04_insertions_TechnoIG.log
@.\04_insertions_TechnoIG.sql
SPOOL OFF

-- Création des vues
SPOOL .\Logs\05_vues_sequences_TechnoIG.log
@.\05_vues_sequences_TechnoIG.sql
SPOOL OFF

-- Création des triggers
SPOOL .\Logs\06_triggers_TechnoIG.log
@.\06_triggers_TechnoIG.sql
SPOOL OFF

-- Création des packages
SPOOL .\Logs\07_packages_TechnoIG.log
@.\07_packages_TechnoIG.sql
SPOOL OFF

-- Connexion à XE en tant que system
CONNECT system/manager@XE

-- Création des synonymes
SPOOL .\Logs\08_synonymes_TechnoIG.log
@.\08_synonymes_TechnoIG.sql
SPOOL OFF

SET ECHO OFF

EXIT;