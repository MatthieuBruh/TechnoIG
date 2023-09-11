-- ====================================================================
-- Script : uninstall_TechnoIG.sql
-- Objet  : Suppression de tous les obejts de la base TechnoIG
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- 1.0	    MB   09.05.2022  EN COURS DE DEVELOPPEMENT
-- ====================================================================



-- Suppression des utilisateurs (CASCADE), rôles et profil
SPOOL .\Logs\uninstall_EasyCooking.log

--=============================================
--Suppression des rôles, utilisateurs et profil
--=============================================
--Suppression des utilisateurs
DROP USER TechnoIG_data CASCADE;
DROP USER TechnoIG_user CASCADE;

--Suppression des rôles
DROP ROLE role_TechnoIG_data CASCADE;
DROP ROLE role_TechnoIG_user CASCADE;

--Suppression du profil
DROP PROFILE TechnoIG_profil;

SPOOL OFF

EXIT;