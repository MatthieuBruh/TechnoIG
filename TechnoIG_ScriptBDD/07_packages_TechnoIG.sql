-- ====================================================================
-- Script : 07_packages_TechnoIG.sql
-- Objet  : Création et suppression des triggers TechnoIG
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- 1.0      MB   10.05.2022  EN COURS DE DEVELOPPEMENT
-- ====================================================================


-- ====================================================
-- Gestion des commandes clients
-- ====================================================

create or replace package pkg_gestionCmdClients is

  -- Author  : MATTH
  -- Created : 05.05.2022 09:53:34
  -- Purpose : Cr�ation des commandes clients

  FUNCTION CrtNewClientCmd(i_cli_no IN tec_client.cli_no%TYPE, i_per_no IN tec_personnel.per_no%TYPE, i_bon_no IN tec_bon.bon_no%TYPE) RETURN tec_commande_cli.com_no%TYPE;
  PROCEDURE AddLigneCmdClient(i_com_no IN tec_commande_cli.com_no%TYPE, i_pro_no IN tec_produit.pro_no%TYPE, i_quantite IN tec_ligne_com_cli.lig_nombre%TYPE);
  PROCEDURE deleteCommandeClient(i_com_no IN tec_commande_cli.com_no%TYPE);

end pkg_gestionCmdClients;
/
create or replace package body pkg_gestionCmdClients IS

  PROCEDURE DeleteAll(i_com_no IN tec_commande_cli.com_no%TYPE) IS
  BEGIN
    DELETE FROM tec_ligne_com_cli WHERE lig_com_no = i_com_no;
    UPDATE tec_bon SET bon_no_commande = NULL WHERE bon_no_commande = i_com_no;
    DELETE FROM tec_commande_cli WHERE com_no = i_com_no;
    COMMIT;
  END DeleteAll;


  -- Ajout d'une commande

  FUNCTION CrtNewClientCmd(i_cli_no IN tec_client.cli_no%TYPE, i_per_no IN tec_personnel.per_no%TYPE, i_bon_no IN tec_bon.bon_no%TYPE) RETURN tec_commande_cli.com_no%TYPE IS
    v_com_no tec_commande_cli.com_no%TYPE;
    v_cli_no tec_client.cli_no%TYPE;
    v_per_no tec_personnel.per_no%TYPE;
    v_bon tec_bon%ROWTYPE;
  BEGIN
    -- On va chercher le num�ro de commande
    SELECT sq_tec_commandes_clients.nextval INTO v_com_no FROM DUAL;

    -- Permet de v�rifier que le client existe et que le bon lui appartient
    BEGIN
      SELECT cli_no INTO v_cli_no FROM TEC_CLIENT WHERE cli_no = i_cli_no;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR (-20001, i_cli_no || ' n''est pas attribu� � un client. Commande annul�e');
    END;

    -- Permet de v�rifier que le personnel existe
    BEGIN
      SELECT i_per_no INTO v_per_no FROM TEC_PERSONNEL WHERE per_no = i_per_no;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR (-20001, i_per_no || ' n''est pas attribu� � un membre du personnel. Commande annul�e');
    END;
    
    -- Gestion des bons
    IF i_bon_no IS NOT NULL THEN
      BEGIN
        SELECT * INTO v_bon FROM tec_bon WHERE bon_no = i_bon_no;
        IF v_cli_no != v_bon.bon_cli_no THEN
          RAISE_APPLICATION_ERROR (-20006, 'Le bon ' || i_bon_no || ' n''est pas attribu� au client ' || v_cli_no || ' Commande annul�e');
        ELSIF  v_bon.bon_no_commande IS NOT NULL THEN
          RAISE_APPLICATION_ERROR (-20007, 'Le bon ' || i_bon_no || ' a d�j� �t� utilis� par le client Commande annul�e');
        ELSE
          UPDATE TEC_BON SET bon_no_commande = v_com_no WHERE bon_no = i_bon_no;
        END IF;
      END;
    END IF;

    -- Ajout de la commande
    INSERT INTO TEC_COMMANDE_CLI VALUES (v_com_no, TRUNC(SYSDATE), v_cli_no, v_per_no);

    -- Validation de la commande et retour du num�ro de commande
    COMMIT;
    RETURN v_com_no;
  END CrtNewClientCmd;


  -- Ligne de commandes

  PROCEDURE AddLigneCmdClient(i_com_no IN tec_commande_cli.com_no%TYPE, i_pro_no IN tec_produit.pro_no%TYPE, i_quantite IN tec_ligne_com_cli.lig_nombre%TYPE) IS
    v_com_no TEC_COMMANDE_CLI.com_no%TYPE;
    v_produit TEC_PRODUIT%ROWTYPE;
  BEGIN
    -- V�rification que la commande existe
    BEGIN
      SELECT com_no INTO v_com_no FROM TEC_COMMANDE_CLI WHERE com_no = i_com_no;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        DeleteAll(v_com_no);
        RAISE_APPLICATION_ERROR (-20001, i_com_no || ' n''est pas un num�ro de commande valide. Commande annul�e');
    END;

    -- V�rification que le produit existe ainsi que la quantit� soit suffisante
    BEGIN
      SELECT * INTO v_produit FROM TEC_PRODUIT WHERE pro_no = i_pro_no;
      IF v_produit.pro_stock < i_quantite THEN
        DeleteAll(v_com_no);
        RAISE_APPLICATION_ERROR (-20002, 'Le stock restant du produit ' || i_pro_no || ' est trop faible. Commande annul�e');
       END IF;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        DeleteAll(v_com_no);
        RAISE_APPLICATION_ERROR (-20001, i_pro_no || ' n''est pas un num�ro de produit valide. Commande annul�e');
    END;

    -- Insertion de la ligne de commande
    BEGIN
      INSERT INTO TEC_LIGNE_COM_CLI VALUES (v_com_no, v_produit.pro_no, i_quantite, v_produit.pro_prix_vente);
    EXCEPTION
      WHEN OTHERS THEN
        DeleteAll(v_com_no);
        RAISE_APPLICATION_ERROR (-20005, i_pro_no || ' Un probl�me est survenu lors de l''ajout de la ligne de commande. Commande annul�e');
    END;
    

    -- Validation de la ligne de commande
    COMMIT;
  END AddLigneCmdClient;

  PROCEDURE deleteCommandeClient(i_com_no IN tec_commande_cli.com_no%TYPE) IS
    v_commande_cli tec_commande_cli%ROWTYPE;
  BEGIN
    SELECT * INTO v_commande_cli FROM tec_commande_cli WHERE com_no = i_com_no;

    dbms_output.put_line(ROUND(SYSDATE - v_commande_cli.com_date, 0));
    IF ROUND(SYSDATE - v_commande_cli.com_date, 0) <= 1 THEN
      DeleteAll(i_com_no);
    ELSE
      RAISE_APPLICATION_ERROR(-20004, i_com_no || ' est une commande trop ancienne pour �tre supprim�e. Impossible de supprimer.');
    END IF;
  EXCEPTION
    WHEN NO_DATA_FOUND THEN
      RAISE_APPLICATION_ERROR (-20003, i_com_no || ' n''est pas un num�ro de commande valide. Impossible de supprimer');
  END deleteCommandeClient;

end pkg_gestionCmdClients;

/
GRANT EXECUTE ON pkg_gestionCmdClients TO role_TechnoIG_user;
/



-- ====================================================
-- Gestion des commandes fournisseurs
-- ====================================================
/
create or replace package pkg_gestionCmdFournisseur is

  -- Author  : MATTH
  -- Created : 07.05.2022 18:22:09
  -- Purpose : Gestion des commandes fournisseurs

  FUNCTION CrtNewCmdFou RETURN TEC_COMMANDE_FOU.com_no%TYPE;
  PROCEDURE AddLigneCmdFou(i_com_no IN tec_commande_fou.com_no%TYPE, i_pro_no IN tec_produit.pro_no%TYPE);

end pkg_gestionCmdFournisseur;
/
create or replace package body pkg_gestionCmdFournisseur IS


  PROCEDURE DeleteAll(i_com_no IN tec_commande_fou.com_no%TYPE) IS
  BEGIN
    DELETE FROM tec_ligne_com_fou WHERE lig_com_no = i_com_no;
    DELETE FROM tec_commande_fou WHERE com_no = i_com_no;
    COMMIT;
  END DeleteAll;


  -- Ajout d'une commande
  FUNCTION CrtNewCmdFou RETURN TEC_COMMANDE_FOU.com_no%TYPE IS
    v_com_no tec_commande_fou.com_no%TYPE;
  BEGIN
    -- On va chercher le num�ro de commande
    SELECT sq_tec_commandes_fournisseurs.nextval INTO v_com_no FROM DUAL;
    -- Ajout de la commande
    INSERT INTO TEC_COMMANDE_FOU VALUES (v_com_no, TRUNC(SYSDATE));

    -- Validation de la commande et retour du num�ro de commande
    COMMIT;
    RETURN v_com_no;
  EXCEPTION
    WHEN OTHERS THEN
      RAISE_APPLICATION_ERROR (-20040, 'Un probm�me est survenu lors de l''insertion de la commande fournisseur. Commande annul�e');
  END CrtNewCmdFou;


  -- Ajout de la ligne de commande
  PROCEDURE AddLigneCmdFou(i_com_no IN tec_commande_fou.com_no%TYPE, i_pro_no IN tec_produit.pro_no%TYPE) IS
    v_com_no TEC_COMMANDE_CLI.com_no%TYPE;
    v_produit TEC_PRODUIT%ROWTYPE;
    v_quantite NUMBER := 1;
  BEGIN

    -- V�rification que la commande existe
    BEGIN
      SELECT com_no INTO v_com_no FROM TEC_COMMANDE_FOU WHERE com_no = i_com_no;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR (-20041, i_com_no || ' n''est pas un num�ro de commande valide. Commande annul�e');
    END;

    -- V�rification que le produit existe ainsi la quantit� n�cessaire
    BEGIN
      SELECT * INTO v_produit FROM TEC_PRODUIT WHERE pro_no = i_pro_no;
      WHILE (v_quantite * v_produit.pro_lot + v_produit.pro_stock) <= v_produit.pro_seuil LOOP
        v_quantite := v_quantite + 1;
      END LOOP;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        DeleteAll(v_com_no);
        RAISE_APPLICATION_ERROR (-20042, i_pro_no || ' n''est pas un num�ro de produit valide. Commande annul�e');
    END;

    -- Insertion de la ligne de commande
    BEGIN
      INSERT INTO TEC_LIGNE_COM_FOU VALUES (v_com_no, v_produit.pro_no, v_quantite * v_produit.pro_lot, v_produit.pro_prix_achat);
    EXCEPTION
      WHEN OTHERS THEN
        DeleteAll(v_com_no);
        RAISE_APPLICATION_ERROR (-20045, i_pro_no || ' Un probl�me est survenu lors de l''ajout de la ligne de commande. Commande annul�e');
    end;

    -- Validation de la ligne de commande
    COMMIT;
  END AddLigneCmdFou;


end pkg_gestionCmdFournisseur;

/
GRANT EXECUTE ON pkg_gestionCmdFournisseur TO role_TechnoIG_user;
/



-- ====================================================
-- Gestion de la gestion du personnel
-- ====================================================

create or replace package pkg_gestionPersonnel is

  -- Author  : MATTH
  -- Created : 10.05.2022 10:32:12
  -- Purpose : Permet aux membres de se connecter au logiciel

  FUNCTION personnelConnect(i_per_nom_util IN tec_personnel.per_nom_utilisateur%TYPE, i_per_password IN tec_personnel.per_password%TYPE) RETURN NUMBER;
  PROCEDURE changePasswordPersonnel(i_per_nom IN tec_personnel.per_nom%TYPE, i_per_prenom IN tec_personnel.per_prenom%TYPE,
    i_per_nom_util IN tec_personnel.per_nom_utilisateur%TYPE, i_new_password IN tec_personnel.per_password%TYPE);
  PROCEDURE creerPersonnel(i_nom IN vw_creer_modifier_personnel.nom%TYPE, i_prenom IN vw_creer_modifier_personnel.prenom%TYPE, i_utilisateur IN vw_creer_modifier_personnel.utilisateur%TYPE,
    i_fonction IN vw_creer_modifier_personnel.fonction%TYPE, i_password IN vw_creer_modifier_personnel.motdepasse%TYPE);
  PROCEDURE modifierPersonnel(i_prenom IN vw_creer_modifier_personnel.prenom%TYPE, i_nom IN vw_creer_modifier_personnel.nom%TYPE, i_new_fonction IN vw_creer_modifier_personnel.fonction%TYPE);
  PROCEDURE supprimerPersonnel(i_prenom IN vw_creer_modifier_personnel.prenom%TYPE, i_nom IN vw_creer_modifier_personnel.nom%TYPE);
  FUNCTION getPersonnelID(i_nomUtil IN VW_PERSONNEL_DETAILS.username%TYPE) RETURN VW_PERSONNEL_DETAILS.numero%TYPE;

end pkg_gestionPersonnel;
/
create or replace package body pkg_gestionPersonnel is

  FUNCTION personnelConnect(i_per_nom_util IN tec_personnel.per_nom_utilisateur%TYPE, i_per_password IN tec_personnel.per_password%TYPE) RETURN NUMBER IS
    v_personnel tec_personnel%ROWTYPE;
  BEGIN
    SELECT * INTO v_personnel FROM TEC_PERSONNEL WHERE UPPER(per_nom_utilisateur) LIKE UPPER(i_per_nom_util);
    IF v_personnel.per_is_active = 0 THEN
      RAISE_APPLICATION_ERROR (-20056, i_per_nom_util || ' appartient à un compte désactivé. Connexion impossible.');
    END IF;
    IF v_personnel.per_password = i_per_password THEN
      RETURN v_personnel.per_niv_no;
    END IF;
    RETURN 0;
  EXCEPTION
    WHEN NO_DATA_FOUND THEN
      RAISE_APPLICATION_ERROR (-20050, i_per_nom_util || ' n''est pas attribu? ? un membre du personnel. Connexion impossible');
  END personnelConnect;


  PROCEDURE changePasswordPersonnel(i_per_nom IN tec_personnel.per_nom%TYPE, i_per_prenom IN tec_personnel.per_prenom%TYPE,
    i_per_nom_util IN tec_personnel.per_nom_utilisateur%TYPE, i_new_password IN tec_personnel.per_password%TYPE) IS
    v_personnel tec_personnel%ROWTYPE;
  BEGIN
    SELECT * INTO v_personnel FROM TEC_PERSONNEL WHERE UPPER(per_nom) LIKE UPPER(i_per_nom) AND UPPER(per_prenom) LIKE UPPER(i_per_prenom)
    AND UPPER(i_per_nom_util) LIKE UPPER(i_per_nom_util);
    UPDATE TEC_PERSONNEL SET per_password = i_new_password WHERE per_no = v_personnel.per_no;
    COMMIT;
  EXCEPTION
    WHEN NO_DATA_FOUND THEN
      RAISE_APPLICATION_ERROR (-20050, i_per_nom_util || ' n''est pas attribu? ? un membre du personnel. Modification du mot de passe impossible');
    WHEN TOO_MANY_ROWS THEN
      RAISE_APPLICATION_ERROR (-20051, 'La recherche du personnel a aboutie ? plusieurs personnes, merci de v?rifier les champs.');
  END ChangePasswordPersonnel;

  PROCEDURE creerPersonnel(i_nom IN vw_creer_modifier_personnel.nom%TYPE, i_prenom IN vw_creer_modifier_personnel.prenom%TYPE, i_utilisateur IN vw_creer_modifier_personnel.utilisateur%TYPE,
    i_fonction IN vw_creer_modifier_personnel.fonction%TYPE, i_password IN vw_creer_modifier_personnel.motdepasse%TYPE) IS

  BEGIN
    INSERT INTO vw_creer_modifier_personnel VALUES (i_nom, i_prenom, i_utilisateur, i_fonction, i_password);
  END creerPersonnel;

  PROCEDURE modifierPersonnel(i_prenom IN vw_creer_modifier_personnel.prenom%TYPE, i_nom IN vw_creer_modifier_personnel.nom%TYPE, i_new_fonction IN vw_creer_modifier_personnel.fonction%TYPE) IS
    v_nom_util vw_creer_modifier_personnel.utilisateur%TYPE;
  BEGIN
    BEGIN
      SELECT utilisateur INTO v_nom_util FROM vw_creer_modifier_personnel WHERE UPPER(prenom) = UPPER(i_prenom) AND UPPER(nom) = UPPER(i_nom);
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR (-20052, 'Impossible de trouver la personne ' || i_nom || ' ' || i_prenom || ' ! Modification impossible');
    END;
      UPDATE vw_creer_modifier_personnel SET fonction = i_new_fonction WHERE UPPER(utilisateur) = UPPER(v_nom_util);
  END modifierPersonnel;

  PROCEDURE supprimerPersonnel(i_prenom IN vw_creer_modifier_personnel.prenom%TYPE, i_nom IN vw_creer_modifier_personnel.nom%TYPE) IS
    v_nom_util vw_creer_modifier_personnel.utilisateur%TYPE;
  BEGIN
    BEGIN
      SELECT utilisateur INTO v_nom_util FROM vw_creer_modifier_personnel WHERE UPPER(prenom) = UPPER(i_prenom) AND UPPER(nom) = UPPER(i_nom);
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR (-20053, 'Impossible de trouver la personne ' || i_nom || ' ' || i_prenom || ' ! Suppression impossible');
    END;
    DELETE vw_creer_modifier_personnel WHERE UPPER(utilisateur) = UPPER(v_nom_util);
  END supprimerPersonnel;
  
  FUNCTION getPersonnelID(i_nomUtil IN VW_PERSONNEL_DETAILS.username%TYPE) RETURN VW_PERSONNEL_DETAILS.numero%TYPE IS
    v_per_no VW_PERSONNEL_DETAILS.numero%TYPE;
  BEGIN
    SELECT numero INTO v_per_no FROM VW_PERSONNEL_DETAILS WHERE UPPER(username) LIKE UPPER(i_nomUtil);
    RETURN v_per_no;
  EXCEPTION
    WHEN NO_DATA_FOUND THEN
      RAISE_APPLICATION_ERROR (-20054, 'Impossible de trouver le personnel avec le nom d''utilisateur : ' || i_nomUtil);
    WHEN TOO_MANY_ROWS THEN
      RAISE_APPLICATION_ERROR (-20055, 'Plusieurs membre du personne ont un nom d''utilisateur : ' || i_nomUtil);
  END getPersonnelID;

end pkg_gestionPersonnel;
/


/
GRANT EXECUTE ON pkg_gestionPersonnel TO role_TechnoIG_user;
/



-- ====================================================
-- Gestion de la gestion des clients
-- ====================================================

create or replace package pkg_gestionClient is

  -- Author  : MATTH
  -- Created : 12.05.2022 20:15:24
  -- Purpose : Permet de créer et modifier des clients

  PROCEDURE creerClient(i_nom IN vw_creer_modifier_client.nom%TYPE, i_prenom IN vw_creer_modifier_client.prenom%TYPE, i_sexe IN vw_creer_modifier_client.sexe%TYPE,
    i_no_rue IN vw_creer_modifier_client.norue%TYPE, i_nom_rue IN vw_creer_modifier_client.nomrue%TYPE, i_npa IN vw_creer_modifier_client.npa%TYPE,
    i_localite IN vw_creer_modifier_client.localite%TYPE, i_pays IN vw_creer_modifier_client.pays%TYPE);

  PROCEDURE modifierClient(i_numero IN vw_creer_modifier_client.id%TYPE, i_sexe IN vw_creer_modifier_client.sexe%TYPE,
    i_no_rue IN vw_creer_modifier_client.norue%TYPE, i_nom_rue IN vw_creer_modifier_client.nomrue%TYPE, i_npa IN vw_creer_modifier_client.npa%TYPE,
    i_localite IN vw_creer_modifier_client.localite%TYPE, i_pays IN vw_creer_modifier_client.pays%TYPE);


end pkg_gestionClient;
/
create or replace package body pkg_gestionClient is

  PROCEDURE creerClient(i_nom IN vw_creer_modifier_client.nom%TYPE, i_prenom IN vw_creer_modifier_client.prenom%TYPE, i_sexe IN vw_creer_modifier_client.sexe%TYPE,
    i_no_rue IN vw_creer_modifier_client.norue%TYPE, i_nom_rue IN vw_creer_modifier_client.nomrue%TYPE, i_npa IN vw_creer_modifier_client.npa%TYPE,
    i_localite IN vw_creer_modifier_client.localite%TYPE, i_pays IN vw_creer_modifier_client.pays%TYPE) IS

  BEGIN
    IF i_sexe NOT IN ('F', 'M', 'A') THEN
      RAISE_APPLICATION_ERROR(-20015, 'Le sexe du client n''est pas valide (attendu : F, M, A). Insertion impossible');
    END IF;
    INSERT INTO vw_creer_modifier_client VALUES (null, i_nom, i_prenom, i_sexe, i_no_rue, i_nom_rue, i_npa, i_localite, i_pays);
  END creerClient;

  PROCEDURE modifierClient(i_numero IN vw_creer_modifier_client.id%TYPE, i_sexe IN vw_creer_modifier_client.sexe%TYPE,
    i_no_rue IN vw_creer_modifier_client.norue%TYPE, i_nom_rue IN vw_creer_modifier_client.nomrue%TYPE, i_npa IN vw_creer_modifier_client.npa%TYPE,
    i_localite IN vw_creer_modifier_client.localite%TYPE, i_pays IN vw_creer_modifier_client.pays%TYPE) IS
    v_no vw_creer_modifier_client.id%TYPE;
  BEGIN
    BEGIN
      SELECT id INTO v_no FROM vw_creer_modifier_client WHERE id = i_numero;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR(-20016, 'Le client que vous souhaitez modifier n''a pas été trouvé. Modification impossible');
    END;
    IF i_sexe NOT IN ('F', 'M', 'A') THEN
      RAISE_APPLICATION_ERROR(-20015, 'Le sexe du client n''est pas valide (attendu : F, M, A). Insertion impossible');
    END IF;

    UPDATE vw_creer_modifier_client SET sexe = i_sexe, norue = i_no_rue, nomrue = i_nom_rue, npa = i_npa, localite = i_localite, pays = i_pays
    WHERE id = v_no;
  END modifierClient;

end pkg_gestionClient;

/
GRANT EXECUTE ON pkg_gestionClient TO role_TechnoIG_user;
/