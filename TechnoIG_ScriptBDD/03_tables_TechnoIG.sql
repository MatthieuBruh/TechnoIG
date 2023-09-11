-- ====================================================================
-- Script : 03_tables_TechnoIG.sql
-- Objet  : Création et suppression des tables TechnoIG
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- 2.0	    MB   03.05.2022  TERMINÉ
-- ====================================================================


-- ====================================================
-- Suppression des tables
-- ====================================================


DROP TABLE TEC_COMMANDE_FOU CASCADE CONSTRAINTS;

DROP TABLE TEC_FOURNISSEUR CASCADE CONSTRAINTS;

DROP TABLE TEC_LIGNE_COM_FOU CASCADE CONSTRAINTS;

DROP TABLE TEC_MARQUE CASCADE CONSTRAINTS;

DROP TABLE TEC_COMMANDE_CLI CASCADE CONSTRAINTS;

DROP TABLE TEC_BON CASCADE CONSTRAINTS;

DROP TABLE TEC_NIVEAU_HIERARCHIQUE CASCADE CONSTRAINTS;

DROP TABLE TEC_LIGNE_COM_CLI CASCADE CONSTRAINTS;

DROP TABLE TEC_PERSONNEL CASCADE CONSTRAINTS;

DROP TABLE TEC_CLIENT CASCADE CONSTRAINTS;

DROP TABLE TEC_CATEGORIE CASCADE CONSTRAINTS;

DROP TABLE TEC_PRODUIT CASCADE CONSTRAINTS;


-- ====================================================
-- Création des tables
-- ====================================================


-- -----------------------------------------------------------------------------
--       TABLE : TEC_COMMANDE_FOU
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_COMMANDE_FOU (
    COM_NO NUMBER(5)  NOT NULL,
    COM_DATE DATE  NOT NULL,
    CONSTRAINT PK_TEC_COMMANDE_FOU PRIMARY KEY (COM_NO)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_FOURNISSEUR
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_FOURNISSEUR (
    FOU_NO NUMBER(5)  NOT NULL,
    FOU_NOM VARCHAR2(60)  NOT NULL,
    FOU_EMAIL VARCHAR2(60)  NOT NULL,
    FOU_NOM_REFERANT VARCHAR2(128)  NULL,
    FOU_NO_RUE NUMBER(4)  NULL,
    FOU_NOM_RUE VARCHAR2(255)  NULL,
    FOU_NPA NUMBER(8)  NULL,
    FOU_NOM_LOCALITE CHAR(255)  NULL,
    FOU_PAYS VARCHAR2(128)  NULL,
    CONSTRAINT PK_TEC_FOURNISSEUR PRIMARY KEY (FOU_NO),
    CONSTRAINT UK_TEC_FOURNISSEUR_NOM UNIQUE(FOU_NOM),
    CONSTRAINT UK_TEC_FOURNISSEUR_EMAIL UNIQUE(FOU_EMAIL)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_LIGNE_COM_FOU
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_LIGNE_COM_FOU (
    LIG_COM_NO NUMBER(5)  NOT NULL,
    LIG_PRO_NO NUMBER(5)  NOT NULL,
    LIG_NOMBRE NUMBER(6)  NOT NULL,
    LIG_PRIX NUMBER(8,2)  NOT NULL,
    CONSTRAINT PK_TEC_LIGNE_COM_FOU PRIMARY KEY (LIG_PRO_NO, LIG_COM_NO),
    CONSTRAINT CH_TEC_LIGNE_COM_FOU_NOMBRE CHECK (LIG_NOMBRE > 0),
    CONSTRAINT CH_TEC_LIGNE_COM_FOU_PRIX CHECK (LIG_PRIX > 0)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_MARQUE
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_MARQUE (
    MAR_NO NUMBER(5)  NOT NULL,
    MAR_NOM VARCHAR2(255)  NOT NULL,
    CONSTRAINT PK_TEC_MARQUE PRIMARY KEY (MAR_NO),
    CONSTRAINT UK_TEC_FOURNISSEUR_MAR_NOM UNIQUE (MAR_NOM)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_COMMANDE_CLI
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_COMMANDE_CLI (
    COM_NO NUMBER(5)  NOT NULL,
    COM_DATE DATE  NOT NULL,
    COM_CLI_NO NUMBER(5)  NOT NULL,
    COM_PER_NO NUMBER(5)  NOT NULL,
    CONSTRAINT PK_TEC_COMMANDE_CLI PRIMARY KEY (COM_NO)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_BON
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_BON (
    BON_NO NUMBER(5)  NOT NULL,
    BON_TAUX NUMBER(3,2)  NOT NULL,
    BON_CLI_NO NUMBER(5)  NOT NULL,
    BON_NO_COMMANDE NUMBER(5)  NULL,
    CONSTRAINT PK_TEC_BON PRIMARY KEY (BON_NO),
    CONSTRAINT CH_TEC_BON_TAUX CHECK (BON_TAUX BETWEEN 0 AND 1)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_NIVEAU_HIERARCHIQUE
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_NIVEAU_HIERARCHIQUE (
    NIV_NO NUMBER(5)  NOT NULL,
    NIV_NOM VARCHAR2(32)  NOT NULL,
    CONSTRAINT PK_TEC_NIVEAU_HIERARCHIQUE PRIMARY KEY (NIV_NO),
    CONSTRAINT UK_TEC_NIVEAU_HIERARCHIQUE UNIQUE (NIV_NOM)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_LIGNE_COM_CLI
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_LIGNE_COM_CLI (
    LIG_COM_NO NUMBER(5)  NOT NULL,
    LIG_PRO_NO NUMBER(5)  NOT NULL,
    LIG_NOMBRE NUMBER(6)  NOT NULL,
    LIG_PRIX NUMBER(13,2)  NOT NULL,
    CONSTRAINT PK_TEC_LIGNE_COM_CLI PRIMARY KEY (LIG_COM_NO, LIG_PRO_NO),
    CONSTRAINT CH_TEC_LIGNE_COM_CLI_NOMBRE CHECK (LIG_NOMBRE > 0),
    CONSTRAINT CH_TEC_LIGNE_COM_CLI_PRIX CHECK (LIG_PRIX > 0)
);


-- -----------------------------------------------------------------------------
--       TABLE : TEC_PERSONNEL
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_PERSONNEL (
    PER_NO NUMBER(5)  NOT NULL,
    PER_PRENOM VARCHAR2(128)  NOT NULL,
    PER_NOM VARCHAR2(32)  NOT NULL,
    PER_NOM_UTILISATEUR VARCHAR2(32)  NOT NULL,
    PER_PASSWORD VARCHAR2(255)  NOT NULL,
    PER_IS_ACTIVE NUMBER(1)  DEFAULT 1,
    PER_NIV_NO NUMBER(5)  NOT NULL,
    CONSTRAINT PK_TEC_PERSONNEL PRIMARY KEY (PER_NO),
    CONSTRAINT UK_TEC_PERSONNEL_NOM_PRENOM UNIQUE (PER_PRENOM, PER_NOM),
    CONSTRAINT CH_TEC_PERSONNEL_IS_ACTIVE CHECK (PER_IS_ACTIVE IN (0, 1))
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_CLIENT
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_CLIENT (
    CLI_NO NUMBER(5)  NOT NULL,
    CLI_NOM VARCHAR2(32)  NOT NULL,
    CLI_PRENOM VARCHAR2(32)  NOT NULL,
    CLI_SEXE VARCHAR2(1)  NOT NULL,
    CLI_NOMBRE_POINTS NUMBER(13)  DEFAULT 0,
    CLI_NO_RUE NUMBER(4)  NULL,
    CLI_NOM_RUE VARCHAR2(255)  NULL,
    CLI_NPA NUMBER(6)  NULL,
    CLI_NOM_LOCALITE VARCHAR2(128)  NULL,
    CLI_PAYS VARCHAR2(32)  NULL,
    CONSTRAINT PK_TEC_CLIENT PRIMARY KEY (CLI_NO),
    CONSTRAINT CH_TEC_CLIENT_SEXE CHECK (UPPER(cli_sexe) IN ('F', 'M', 'A')),
    CONSTRAINT UK_TEC_CLIENT_NOM_PRENOM UNIQUE (CLI_PRENOM, CLI_NOM)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_CATEGORIE
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_CATEGORIE (
    CAT_NO NUMBER(5)  NOT NULL,
    CAT_NOM VARCHAR2(32)  NOT NULL,
    CONSTRAINT PK_TEC_CATEGORIE PRIMARY KEY (CAT_NO),
    CONSTRAINT UK_TEC_CATEGORIE_NOM UNIQUE (CAT_NOM)
);

-- -----------------------------------------------------------------------------
--       TABLE : TEC_PRODUIT
-- -----------------------------------------------------------------------------

CREATE TABLE TEC_PRODUIT (
    PRO_NO NUMBER(5)  NOT NULL,
    PRO_NOM VARCHAR2(128)  NOT NULL,
    PRO_STOCK NUMBER(4)  NOT NULL,
    PRO_PRIX_ACHAT NUMBER(13,2)  NOT NULL,
    PRO_PRIX_VENTE NUMBER(13,2)  NOT NULL,
    PRO_SEUIL NUMBER(4)  NOT NULL,
    PRO_LOT NUMBER(4)  NOT NULL,
    PRO_CAT_NO NUMBER(5)  NOT NULL,
    PRO_MAR_NO NUMBER(5)  NOT NULL,
    PRO_FOU_NO NUMBER(5)  NOT NULL,
    CONSTRAINT PK_TEC_PRODUIT PRIMARY KEY (PRO_NO),
    CONSTRAINT CH_TEC_PRODUIT_STOCK CHECK (PRO_STOCK >= 0),
    CONSTRAINT CH_TEC_PRODUIT_PRIX_ACH CHECK (PRO_PRIX_ACHAT > 0),
    CONSTRAINT CH_TEC_PRODUIT_PRIX_VENT CHECK (PRO_PRIX_VENTE > 0),
    CONSTRAINT CH_TEC_PRODUIT_SEUIL CHECK (PRO_SEUIL > 0),
    CONSTRAINT CH_TEC_PRODUIT_LOT CHECK (PRO_LOT > 0)
);

-- -----------------------------------------------------------------------------
--       CREATION DES REFERENCES DE TABLE
-- -----------------------------------------------------------------------------


ALTER TABLE TEC_LIGNE_COM_FOU ADD (
    CONSTRAINT FK_TEC_LIGNE_COM_FOU_TEC_COMMA
    FOREIGN KEY (LIG_COM_NO)
    REFERENCES TEC_COMMANDE_FOU (COM_NO)
);

ALTER TABLE TEC_LIGNE_COM_FOU ADD (
    CONSTRAINT FK_TEC_LIGNE_COM_FOU_TEC_PRODU
    FOREIGN KEY (LIG_PRO_NO)
    REFERENCES TEC_PRODUIT (PRO_NO)
);

ALTER TABLE TEC_COMMANDE_CLI ADD (
    CONSTRAINT FK_TEC_COMMANDE_CLI_TEC_CLIENT
    FOREIGN KEY (COM_CLI_NO)
    REFERENCES TEC_CLIENT (CLI_NO)
);

ALTER TABLE TEC_COMMANDE_CLI ADD (
    CONSTRAINT FK_TEC_COMMANDE_CLI_TEC_PERSON
    FOREIGN KEY (COM_PER_NO)
    REFERENCES TEC_PERSONNEL (PER_NO)
);

ALTER TABLE TEC_BON ADD (
    CONSTRAINT FK_TEC_BON_TEC_CLIENT
    FOREIGN KEY (BON_CLI_NO)
    REFERENCES TEC_CLIENT (CLI_NO)
);

ALTER TABLE TEC_LIGNE_COM_CLI ADD (
    CONSTRAINT FK_TEC_LIGNE_COM_TEC_COM_CLI
    FOREIGN KEY (LIG_COM_NO)
    REFERENCES TEC_COMMANDE_CLI (COM_NO)
);

ALTER TABLE TEC_LIGNE_COM_CLI ADD (
    CONSTRAINT FK_TEC_LIGNE_COM_CLI_TEC_PRODU
    FOREIGN KEY (LIG_PRO_NO)
    REFERENCES TEC_PRODUIT (PRO_NO)
);

ALTER TABLE TEC_PERSONNEL ADD (
    CONSTRAINT FK_TEC_PERSONNEL_TEC_NIVEAUHIE
    FOREIGN KEY (PER_NIV_NO)
    REFERENCES TEC_NIVEAU_HIERARCHIQUE (NIV_NO)
);

ALTER TABLE TEC_PRODUIT ADD (
    CONSTRAINT FK_TEC_PRODUIT_TEC_MARQUE
    FOREIGN KEY (PRO_MAR_NO)
    REFERENCES TEC_MARQUE (MAR_NO)
);

ALTER TABLE TEC_PRODUIT ADD (
    CONSTRAINT FK_TEC_PRODUIT_TEC_CATEGORIE
    FOREIGN KEY (PRO_CAT_NO)
    REFERENCES TEC_CATEGORIE (CAT_NO)
);

ALTER TABLE TEC_PRODUIT ADD (
    CONSTRAINT FK_TEC_PRODUIT_TEC_FOURNISSEUR
    FOREIGN KEY (PRO_FOU_NO)
    REFERENCES TEC_FOURNISSEUR (FOU_NO)
);