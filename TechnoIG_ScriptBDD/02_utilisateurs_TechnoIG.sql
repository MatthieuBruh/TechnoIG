-- ====================================================================
-- Script : 02_utilisateurs_TechnoIG.sql
-- Objet  : Création des utilisateurs BDD TechnoIG sur SGBD Oracle (XE)
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- 1.0	    MB   09.05.2022  TERMINÉ
-- ====================================================================


-- =============================================================================================
-- Suppression des rôles, utilisateurs et profil
-- =============================================================================================

-- Suppression des utilisateurs
DROP USER TechnoIG_data CASCADE;
DROP USER TechnoIG_user CASCADE;

-- Suppression des rôles
DROP ROLE role_TechnoIG_data CASCADE;
DROP ROLE role_TechnoIG_user CASCADE;

-- Suppression du profil
DROP PROFILE TechnoIG_profil;

-- =============================================================================================
-- Création du profil
-- =============================================================================================
-- Creation du profil TechnoIG_profil
CREATE PROFILE TechnoIG_profil LIMIT
	SESSIONS_PER_USER 20
	FAILED_LOGIN_ATTEMPTS 3 
	PASSWORD_LOCK_TIME 1/24
	PASSWORD_LIFE_TIME 180 
	PASSWORD_REUSE_TIME 180 
	PASSWORD_REUSE_MAX UNLIMITED
	PASSWORD_GRACE_TIME 7;

-- =============================================================================================
-- Création du rôle role_TechnoIG_data (rôle de l'utilisateur propriétaire des objets de la base)
-- =============================================================================================
-- Creation du rôle role_TechnoIG_data
CREATE ROLE role_TechnoIG_data;

-- droit de se connecter à la BDD
GRANT CONNECT TO role_TechnoIG_data;

-- droit de créer des triggers, séquence, tables, packages, ...
GRANT RESOURCE TO role_TechnoIG_data;

-- droit de créer des vues
GRANT CREATE VIEW TO role_TechnoIG_data;

-- droit de créer des synonymes
-- GRANT CREATE ANY SYNONYM TO role_TechnoIG_data;
-- ! fonctionne mais donne trop de privilèges, à éviter

-- ===============================
-- Création du rôle role_TechnoIG_user (rôle de l'utilisateur de l'application)
-- ===============================
-- Creation du rôle role_TechnoIG_user
CREATE ROLE role_TechnoIG_user;

-- droit de se connecter à la BDD
GRANT CREATE SESSION TO role_TechnoIG_user;

-- ===================================
-- Création de l'utilisateur TechnoIG_data (propriétaire des objets de schéma de la base)
-- ===================================
-- Creation de l'utilisateur TechnoIG_data 
CREATE USER TechnoIG_data
	PROFILE TechnoIG_profil
	IDENTIFIED BY TechnoIG_data
	DEFAULT TABLESPACE USERS
	TEMPORARY TABLESPACE TEMP
;
GRANT role_TechnoIG_data TO TechnoIG_data;
ALTER USER TechnoIG_data quota unlimited ON USERS;

--===================================
--Création de l'utilisateur TechnoIG_user (utilisateur de l'application)
--===================================
CREATE USER TechnoIG_user
	PROFILE TechnoIG_profil
	IDENTIFIED BY TechnoIG_user
;
GRANT role_TechnoIG_user TO TechnoIG_user;
