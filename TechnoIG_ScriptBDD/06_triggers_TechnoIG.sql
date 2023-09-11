-- ====================================================================
-- Script : 06_triggers_TechnoIG.sql
-- Objet  : Cr�ation et suppression des triggers TechnoIG
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- BETA      MB   04.05.2022  EN COURS DE DEVELOPPEMENT
-- ====================================================================


-- Clients

-- ====================================================
-- Trigger pour la gestion des clients
-- ====================================================

create or replace trigger trg_gestionDesClients
  INSTEAD OF INSERT or UPDATE OR DELETE
  ON vw_creer_modifier_client 
  for each row
declare
  cli_no tec_client.cli_no%TYPE;
BEGIN
  -- Dans le cas de l'ajout d'un nouveau client
  IF INSERTING THEN
    IF :NEW.nom IS NOT NULL AND :NEW.prenom IS NOT NULL AND :new.sexe IN ('F', 'M', 'A') THEN
      SELECT sq_tec_clients.NEXTVAL INTO cli_no FROM DUAL;
      INSERT INTO tec_client VALUES (cli_no, :NEW.nom, :NEW.prenom, :NEW.sexe, 0, :NEW.norue, :NEW.nomrue, :NEW.NPA, :NEW.localite, :NEW.pays);
    ELSE
      RAISE_APPLICATION_ERROR (-20010, 'Impossible d''ins�rer le client, merci de v�rifier les champs : Nom, Prenom et Sexe');
    END IF;

  -- Dans le cas de la modification d'un client existant
  ELSIF UPDATING THEN
    IF UPPER(:OLD.nom) = UPPER(:NEW.nom) AND UPPER(:OLD.prenom) = UPPER(:NEW.prenom) THEN
      UPDATE tec_client SET cli_sexe = :NEW.sexe, cli_no_rue = :NEW.norue, cli_nom_rue = :NEW.nomrue, cli_npa = :NEW.npa, cli_nom_localite = :NEW.localite, cli_pays = :NEW.pays
      WHERE UPPER(cli_nom) LIKE UPPER(:OLD.nom) AND UPPER(cli_prenom) LIKE UPPER(:OLD.prenom);
    ELSE 
      RAISE_APPLICATION_ERROR (-20012, 'Le nom et le pr�nom de la personne ne peuvent pas �tre modifi�s');
    END IF;
 
  -- Dans le cas de la suppression d'un client
  ELSE
    RAISE_APPLICATION_ERROR (-200013, 'La suppression des clients n''est pas g�r�ee dans cette version.');
  END IF;
end trg_gestionDesClients;

/
ALTER TRIGGER trg_gestionDesClients ENABLE;
/




-- Personnel

-- ====================================================
-- Trigger pour la gestion du personnel
-- ====================================================

create or replace trigger trg_gestionDuPersonnel
  instead of insert or update or delete
  on vw_creer_modifier_personnel 
  for each row
declare
  v_per_no tec_personnel.per_no%TYPE;
  v_niv_no tec_personnel.per_no%TYPE;
  NULL_VALUE EXCEPTION;
  PRAGMA EXCEPTION_INIT (NULL_VALUE, -01400);
BEGIN
  -- Gestion des niveaux hi�rarchiques pour les ajoute et mise � jour
  IF INSERTING OR UPDATING THEN
    BEGIN
      SELECT niv_no INTO v_niv_no FROM tec_niveau_hierarchique WHERE UPPER(niv_nom) LIKE UPPER(:NEW.fonction);
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR (-20020, 'Impossible d''ins�rer la personne car sa fonction est invalide.'); 
    END;
  END IF;
  
  -- Dans le cas de l'ajout d'un nouveau membre du personnel
  IF INSERTING THEN
    SELECT sq_tec_personnel.NEXTVAL INTO v_per_no FROM DUAL;
    BEGIN
      INSERT INTO tec_personnel VALUES (v_per_no, :NEW.prenom, :NEW.nom, :NEW.utilisateur, :NEW.motdepasse, 1, v_niv_no);
    EXCEPTION
      WHEN NULL_VALUE THEN
        RAISE_APPLICATION_ERROR (-20021, 'Impossible d''ins�rer le membre du staff car ses donn�es sont incorrectes.');
    END;
    
  
  -- Dans le cas de la modification d'un membre du personnel existant
  ELSIF UPDATING THEN
    IF UPPER(:OLD.nom) = UPPER(:NEW.nom) AND UPPER(:OLD.prenom) = UPPER(:NEW.prenom) AND UPPER(:OLD.utilisateur) = UPPER(:NEW.utilisateur) THEN
      UPDATE tec_personnel SET per_password = :NEW.motdepasse, per_niv_no = v_niv_no WHERE UPPER(per_nom) = UPPER(:OLD.nom) AND UPPER(per_prenom) = UPPER(:OLD.prenom);
    ELSE
      RAISE_APPLICATION_ERROR (-20021, 'La modification de l''employ� ' || v_per_no || ' n''est pas possible car certains champs non autoris� on �t� modifi�s.');
    END IF;
  
  -- Dans le cas de la suppression d'un membre du personnel
  ELSE
    UPDATE tec_personnel SET per_is_active = 0 WHERE UPPER(per_nom) = UPPER(:OLD.nom) AND UPPER(per_prenom) = UPPER(:OLD.prenom);
  END IF;


end trg_gestionDuPersonnel;

/
ALTER TRIGGER trg_gestionDuPersonnel ENABLE;
/



-- Ligne de commandes

-- ====================================================
-- Trigger pour les lignes des commandes client
-- ====================================================

create or replace trigger trg_gestionLigneCmdClients
  AFTER INSERT OR DELETE
  on tec_ligne_com_cli 
  for each row
declare
  my_cli_no tec_client.cli_no%TYPE;
BEGIN
  -- Dans le cas de la cr�ation r�ussie d'une ligne de commande
  IF INSERTING THEN
    UPDATE tec_produit SET pro_stock = pro_stock - :NEW.LIG_NOMBRE WHERE pro_no = :NEW.LIG_PRO_NO;
    BEGIN
      SELECT cli_no into my_cli_no FROM tec_commande_cli JOIN TEC_CLIENT ON com_cli_no = cli_no WHERE com_no = :NEW.LIG_COM_NO;
      UPDATE tec_client SET cli_nombre_points = cli_nombre_points + :NEW.LIG_NOMBRE WHERE cli_no = my_cli_no;
    END;
  -- Dans le cas de la suppr�ssion r�ussie d'une ligne de commande
  ELSIF DELETING THEN
    UPDATE tec_produit SET pro_stock = pro_stock + :OLD.LIG_NOMBRE WHERE pro_no = :OLD.LIG_PRO_NO;
    BEGIN
      SELECT cli_no into my_cli_no FROM tec_commande_cli JOIN TEC_CLIENT ON com_cli_no = cli_no WHERE com_no = :OLD.LIG_COM_NO;
      UPDATE tec_client SET cli_nombre_points = cli_nombre_points - :OLD.LIG_NOMBRE WHERE cli_no = my_cli_no;
    END;
  END IF;
end trg_gestionLigneCmdClients;

/
ALTER TRIGGER trg_gestionLigneCmdClients ENABLE;
/



-- Bons clients

-- ====================================================
-- Gestion des bons clients
-- ====================================================

CREATE OR REPLACE TRIGGER trg_gestionDesBonsClients
   BEFORE UPDATE
  ON tec_client 
  FOR EACH ROW
DECLARE
  new_bon_taux tec_bon.bon_taux%TYPE;
BEGIN
  IF :OLD.CLI_NOMBRE_POINTS < 200 AND 200 <= :NEW.CLI_NOMBRE_POINTS THEN
    new_bon_taux := 0.01;
  ELSIF :OLD.CLI_NOMBRE_POINTS < 400 AND 400 <= :NEW.CLI_NOMBRE_POINTS THEN
    new_bon_taux := 0.02;
  ELSIF :OLD.CLI_NOMBRE_POINTS < 600 AND 600 <= :NEW.CLI_NOMBRE_POINTS THEN
    new_bon_taux := 0.03;
  ELSIF :OLD.CLI_NOMBRE_POINTS < 800 AND 800 <= :NEW.CLI_NOMBRE_POINTS THEN
    new_bon_taux := 0.04;
  ELSIF :OLD.CLI_NOMBRE_POINTS < 1000 AND 1000 <= :NEW.CLI_NOMBRE_POINTS THEN
    new_bon_taux := 0.05;
  END IF;
  
  -- Dans le cas o� le nombre points d�passe 1000
  IF 1000 <= :NEW.CLI_NOMBRE_POINTS THEN
    :NEW.CLI_NOMBRE_POINTS := :NEW.CLI_NOMBRE_POINTS - 1000;
  END IF;
  
  -- Dans le cas o� il faut ajouter un nouveau bon
  IF new_bon_taux IS NOT NULL THEN
    INSERT INTO tec_bon VALUES (sq_tec_bon.nextval, new_bon_taux, :NEW.CLI_NO, NULL);
  END IF;

EXCEPTION
  WHEN OTHERS THEN
    RAISE_APPLICATION_ERROR (-20030, :OLD.CLI_NO || ' a eu un probl�me avec la gestion de ses points.');
END trg_gestionDesBonsClients;

/
ALTER TRIGGER trg_gestionDesBonsClients ENABLE;
/



-- Ligne de commandes

-- ====================================================
-- Trigger pour les lignes des commandes fournisseurs
-- ====================================================

create or replace trigger trg_gestionLigneCmdFou
  after insert or delete
  on tec_ligne_com_fou 
  for each row
declare
  -- local variables here
  v_produit TEC_PRODUIT%ROWTYPE;
begin
  -- Dans le cas de la cr�ation r�ussie d'une ligne de commande
  IF INSERTING THEN
    UPDATE tec_produit SET pro_stock = pro_stock + :NEW.LIG_NOMBRE WHERE pro_no = :NEW.LIG_PRO_NO;
  -- Dans le cas de la suppr�ssion r�ussie d'une ligne de commande
  ELSIF DELETING THEN
    SELECT * INTO v_produit FROM tec_produit WHERE pro_no = :OLD.LIG_PRO_NO;
    IF (v_produit.pro_stock - (:OLD.LIG_NOMBRE * v_produit.pro_lot)) < 0 THEN
      UPDATE tec_produit SET pro_stock = 0 WHERE pro_no = :OLD.LIG_PRO_NO;
    ELSE
      UPDATE tec_produit SET pro_stock = pro_stock - :OLD.LIG_NOMBRE WHERE pro_no = :OLD.LIG_PRO_NO;
    END IF;
  END IF;
end trg_gestionLigneCmdFou;

/
ALTER TRIGGER trg_gestionLigneCmdFou ENABLE;
/
