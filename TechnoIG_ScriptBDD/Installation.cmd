REM Fichier		: Installation.cmd
REM Objet		: Création de la BDD TechnoIG

mkdir .\Logs

REM Lancement du script 01_BDD_TechnoIG.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM/manager@XE @%~dp0\01_BDD_TechnoIG.sql %~dp0
