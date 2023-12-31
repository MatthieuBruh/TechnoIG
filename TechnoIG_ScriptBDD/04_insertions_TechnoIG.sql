-- ====================================================================
-- Script : 04_insertions_TechnoIG.sql
-- Objet  : Création et suppression des données TechnoIG
--
--
-- Version  Visa Date        Commentaires
-- -------  ---- ----------  ----------------------------------
-- 2.0	    MB   03.05.2022  TERMINÉ
-- ====================================================================


-- /!\ ATTENTION : Les valeurs sont des valeurs de tests.
-- De ce fait, certains champs ne sont pas cohérents.
-- Les champs concernés sont :
-- TEC_LIGNE_COM_FOU.LIG_PRIX <=!=> TEC_PRODUIT.PR_PRIX_ACHAT
-- TEC_LIGNE_COM_CLI.LIG_PRIX <=!=> TEC_PRODUIT.PR_PRIX_VENTE
-- TEC_BON.BON_TAUX <=!=> TEC_CLIENT.CLI_NOMBRE_POINTS


-- ====================================================
-- Insertion des niveaux hiérarchiques
-- ====================================================

INSERT INTO TEC_NIVEAU_HIERARCHIQUE VALUES(1, 'Manager');
INSERT INTO TEC_NIVEAU_HIERARCHIQUE VALUES(2, 'Vendeur');
COMMIT;


-- ====================================================
-- Insertion du personnel
-- ====================================================

INSERT INTO TEC_PERSONNEL VALUES (1, 'Ibby', 'Douche', 'idouche', '07480fb9e85b9396af06f006cf1c95024af2531c65fb505cfbd0add1e2f31573', 1, 1);
INSERT INTO TEC_PERSONNEL VALUES (2, 'Kat', 'Fried', 'kfried', '07480fb9e85b9396af06f006cf1c95024af2531c65fb505cfbd0add1e2f31573', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (3, 'Norah', 'Logue', 'nlogue2', 'lKR7Kh', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (4, 'Dorie', 'Opdenorth', 'dopdenorth3', '0PkQd4', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (5, 'Maurizio', 'Fowlie', 'mfowlie4', 'Np4ju0kmxf', 1, 2); 
INSERT INTO TEC_PERSONNEL VALUES (6, 'Conny', 'Vallintine', 'cvallintine5', 'EHxZ3pR5GEF', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (7, 'Markus', 'Bysshe', 'mbysshe6', '0RvRUMbMKq', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (8, 'Karlan', 'Casel', 'kcasel7', 'HQ9D7n5', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (9, 'Dud', 'Arnauduc', 'darnauduc8', 'uW7Sr5mp', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (10, 'Brandais', 'Wandless', 'bwandless9', 'kFYv6rEEzts', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (11, 'Brandi', 'Dowrey', 'bdowreya', 'ev3d0t6D', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (12, 'Row', 'Millins', 'rmillinsb', 'YYex5Xcb5yf7', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (13, 'Hasheem', 'Coonan', 'hcoonanc', 'Gysl0S3v', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (14, 'Edwina', 'Cuttles', 'ecuttlesd', 'r9hAJz520Jn', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (15, 'Elie', 'Rutigliano', 'erutiglianoe', 'u017E0IA', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (16, 'Delphine', 'Hamelyn', 'dhamelynf', '5tbt2WcjUJPX', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (17, 'Bunny', 'Furmagier', 'bfurmagierg', '4XFtJN', 1, 2);
INSERT INTO TEC_PERSONNEL VALUES (18, 'Perkin', 'Donaghie', 'pdonaghieh', 'P8Ao0jQ', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (19, 'Nari', 'Hassey', 'nhasseyi', 'AusB9IdqoYi2', 0, 2);
INSERT INTO TEC_PERSONNEL VALUES (20, 'Siward', 'Scyner', 'sscynerj', 'zT4MxZM', 1, 2);
COMMIT;


-- ====================================================
-- Insertion des marques
-- ====================================================

INSERT INTO TEC_MARQUE VALUES (1, 'Asus');
INSERT INTO TEC_MARQUE VALUES (2, 'Acer');
INSERT INTO TEC_MARQUE VALUES (3, 'Gigabyte');
INSERT INTO TEC_MARQUE VALUES (4, 'ColorMaster');
INSERT INTO TEC_MARQUE VALUES (5, 'Seasonic');
INSERT INTO TEC_MARQUE VALUES (6, 'Corsair');
INSERT INTO TEC_MARQUE VALUES (7, 'MSI');
INSERT INTO TEC_MARQUE VALUES (8, 'Intel');
INSERT INTO TEC_MARQUE VALUES (9, 'Nvidia');
INSERT INTO TEC_MARQUE VALUES (10, 'AMD');
INSERT INTO TEC_MARQUE VALUES (11, 'Noctua');
INSERT INTO TEC_MARQUE VALUES (12, 'BeQuiet');
INSERT INTO TEC_MARQUE VALUES (13, 'DELL');
INSERT INTO TEC_MARQUE VALUES (14, 'Logitec G');
INSERT INTO TEC_MARQUE VALUES (15, 'Samsung');
INSERT INTO TEC_MARQUE VALUES (16, 'Oculus');
INSERT INTO TEC_MARQUE VALUES (17, 'HTC');
COMMIT;


-- ====================================================
-- Insertion des catégories
-- ====================================================

INSERT INTO TEC_CATEGORIE VALUES (1, 'Carte mere');
INSERT INTO TEC_CATEGORIE VALUES (2, 'Processeur');
INSERT INTO TEC_CATEGORIE VALUES (3, 'Carte graphique');
INSERT INTO TEC_CATEGORIE VALUES (4, 'Stockage');
INSERT INTO TEC_CATEGORIE VALUES (5, 'RAM');
INSERT INTO TEC_CATEGORIE VALUES (6, 'Alimentation');
INSERT INTO TEC_CATEGORIE VALUES (7, 'Refroidissement');
INSERT INTO TEC_CATEGORIE VALUES (8, 'Lecteur disque');
INSERT INTO TEC_CATEGORIE VALUES (9, 'Casque');
INSERT INTO TEC_CATEGORIE VALUES (10, 'Clavier');
INSERT INTO TEC_CATEGORIE VALUES (11, 'Souris');
INSERT INTO TEC_CATEGORIE VALUES (12, 'Casque VR');
COMMIT;


-- ====================================================
-- Insertion des fournisseurs
-- ====================================================

INSERT INTO TEC_FOURNISSEUR VALUES (1, 'Toy Group', 'idibnah0@tripod.com', 'Dibnah', '6', 'Mayfield', 1228, 'Magsaysay', 'Philippines');
INSERT INTO TEC_FOURNISSEUR VALUES (2, 'Harris Inc', 'cbarrett1@auda.org.au', 'Barrett', '1660', 'Monica', 12112, 'Arcueil', 'France');
INSERT INTO TEC_FOURNISSEUR VALUES (3, 'Stoltenberg and Sons', 'fbridgens2@flickr.com', 'Bridgens', '05703', 'Golf Course', 13310, 'Ragay', 'Philippines');
INSERT INTO TEC_FOURNISSEUR VALUES (4, 'Jenkins-Bosco', 'kcatchpole3@mapquest.com', 'Catchpole', '53', 'Westport', 1233, 'Racine', 'United States');
INSERT INTO TEC_FOURNISSEUR VALUES (5, 'Stamm-Bartoletti', 'ddermot4@archive.org', 'Dermot', '2045', 'Dahle', 1222, 'Lianhe', 'China');
INSERT INTO TEC_FOURNISSEUR VALUES (6, 'Orn Inc', 'lskym5@nsw.gov.au', 'Skym', '108', 'Debs', 2333, 'Cibeureum', 'Indonesia');
INSERT INTO TEC_FOURNISSEUR VALUES (7, 'Rolfson LLC', 'mmenichillo6@cargocollective.com', 'Menichillo', '8', 'Independence', 1234, 'Trelleborg', 'Sweden');
INSERT INTO TEC_FOURNISSEUR VALUES (8, 'Gleason, Zboncak and Moore', 'ibrymham7@quantcast.com', 'Brymham', '3', 'Springview', 1235, 'Sérvia', 'Greece');
INSERT INTO TEC_FOURNISSEUR VALUES (9, 'Hackett, Windler and Roberts', 'ngibke8@wix.com', 'Gibke', '0', 'Riverside', 1272, 'Shiye', 'China');
INSERT INTO TEC_FOURNISSEUR VALUES (10, 'Stamm-Harris', 'rcarrane9@ucoz.ru', 'Carrane', '352', 'Sunnyside', 1272, 'Puerto Santander', 'Colombia');
INSERT INTO TEC_FOURNISSEUR VALUES (11, 'Hansen-Reynolds', 'lcardenosoa@baidu.com', 'Cardenoso', '3344', 'Forest Dale', 1260, 'Yanzhou', 'China');
INSERT INTO TEC_FOURNISSEUR VALUES (12, 'Pacocha, Berge and Lakin', 'aengledowb@arizona.edu', 'Engledow', '9271', 'Towne', 1271, 'Regla', 'Cuba');
INSERT INTO TEC_FOURNISSEUR VALUES (13, 'Leannon and Sons', 'mcheyennec@imgur.com', 'Cheyenne', '8434', 'Emmet', 62733, 'Kuroishi', 'Japan');
COMMIT;


-- ====================================================
-- Insertion des produits
-- ====================================================

INSERT INTO TEC_PRODUIT VALUES (1, 'ROG STRIX Z690-F', 50, 400, 450, 10, 30, 1, 1, 3);
INSERT INTO TEC_PRODUIT VALUES (2, 'Pro Z690- Wifi D4', 23, 220, 232, 8, 15, 1, 7, 4);
INSERT INTO TEC_PRODUIT VALUES (3, 'Mag Z690 Tomahawk Wifi Ddr4', 12, 200, 263, 23, 5, 1, 7, 6);
INSERT INTO TEC_PRODUIT VALUES (4, 'Core i7-12700K', 10, 430, 442, 4, 20, 2, 8, 12);
INSERT INTO TEC_PRODUIT VALUES (5, 'Ryzen 7 5800X', 12, 400, 414, 20, 5, 2, 10, 1);
INSERT INTO TEC_PRODUIT VALUES (6, 'Core i9-12900K', 15, 500, 581, 4, 6, 2, 8, 10);
INSERT INTO TEC_PRODUIT VALUES (7, 'Radeon RX 6600 XT OC Edition', 4, 455, 487, 2, 3, 3, 8, 5);
INSERT INTO TEC_PRODUIT VALUES (8, 'Radeon RX 6600 MECH 2X 8G', 50, 400, 399, 10, 30, 3, 7, 3);
INSERT INTO TEC_PRODUIT VALUES (9, 'AORUS GeForce RTX 3080 MASTER', 8, 1280, 1310, 2, 4, 3, 9, 8);
INSERT INTO TEC_PRODUIT VALUES (10, '970 EVO Plus', 22, 120, 128, 15, 10, 4, 15, 9);
INSERT INTO TEC_PRODUIT VALUES (11, 'Portable T7 Titan Grey', 12, 200, 229, 15, 10, 4, 15, 10);
INSERT INTO TEC_PRODUIT VALUES (12, '980 Pro', 12, 150, 165, 10, 3, 4, 15, 11);
INSERT INTO TEC_PRODUIT VALUES (13, '870 EVO', 25, 50, 75, 15, 5, 4, 15, 13);
INSERT INTO TEC_PRODUIT VALUES (14, 'Vengeance RGB Pro', 20, 150, 152, 5, 4, 5, 6, 13);
INSERT INTO TEC_PRODUIT VALUES (15, 'AA075845', 25, 140, 159, 10, 8, 5, 13, 4);
INSERT INTO TEC_PRODUIT VALUES (16, 'Straight Power 11', 20, 135, 151, 5, 10, 6, 12, 4);
INSERT INTO TEC_PRODUIT VALUES (17, 'ROG Thor 850P', 15, 150, 189, 8, 6, 6, 1, 5);
INSERT INTO TEC_PRODUIT VALUES (18, 'CX750F RGB', 24, 60, 91.20, 5, 8, 6, 6, 7);
INSERT INTO TEC_PRODUIT VALUES (19, 'NH-D15 Chromax', 43, 100, 113, 9, 4, 7, 11, 7);
INSERT INTO TEC_PRODUIT VALUES (20, 'Dark Rock Pro 4', 21, 60, 80, 3, 6, 7, 12, 8);
INSERT INTO TEC_PRODUIT VALUES (21, 'BW-16D1HT/B EN VRAC SILENCIEUX', 20, 78, 94.70, 4, 3, 8, 1, 10);
INSERT INTO TEC_PRODUIT VALUES (22, 'DRW-24D5MT', 40, 15, 23.80, 5, 10, 8, 1, 11);
INSERT INTO TEC_PRODUIT VALUES (23, 'Pro X Lightspeed', 25, 160, 179, 10, 5, 9, 14, 2);
INSERT INTO TEC_PRODUIT VALUES (24, 'Virtuoso XT', 34, 178, 237, 9, 5, 9, 6, 3);
INSERT INTO TEC_PRODUIT VALUES (25, 'G915 TKL', 12, 179, 195, 5, 7, 10, 14, 4);
INSERT INTO TEC_PRODUIT VALUES (26, 'K100', 8, 255, 270, 2, 4, 10, 6, 5);
INSERT INTO TEC_PRODUIT VALUES (27, 'K65 RGB Mini', 22, 111, 128, 12, 4, 10, 6, 7);
INSERT INTO TEC_PRODUIT VALUES (28, 'G502 Lightspeed', 21, 130, 140, 5, 10, 11, 14, 6);
INSERT INTO TEC_PRODUIT VALUES (29, 'Glaive RGB Pro', 32, 100, 111, 8, 5, 11, 6, 6);
INSERT INTO TEC_PRODUIT VALUES (30, 'G903', 12, 100, 116, 10, 5, 11, 14, 7);
INSERT INTO TEC_PRODUIT VALUES (31, 'Quest 2 128 GB', 4, 380, 399, 2, 3, 12, 16, 1);
INSERT INTO TEC_PRODUIT VALUES (32, 'Quest 2 128 GB + Link Cable', 10, 450, 480, 2, 2, 12, 16, 4);
INSERT INTO TEC_PRODUIT VALUES (33, 'Vive Pro 2 Headset', 8, 777, 799, 6, 2, 12, 17, 12);
COMMIT;

-- ====================================================
-- Insertion des clients
-- ====================================================

INSERT INTO TEC_CLIENT VALUES (1, 'Hirche', 'Othelia', 'F', 944, 94, 'Wayridge', 1222, 'Huangshapu', 'China');
INSERT INTO TEC_CLIENT VALUES (2, 'Lewton', 'Gav', 'M', 959, 7, 'Kipling', 1222, 'Sambonggede', 'Indonesia');
INSERT INTO TEC_CLIENT VALUES (3, 'Easlea', 'Wittie', 'M', 662, 22, 'Gale', 1222, 'Yingzai', 'China');
INSERT INTO TEC_CLIENT VALUES (4, 'Lindenboim', 'Zacharie', 'M', 532, 8, 'Prairieview', 1222, 'Chegang', 'China');
INSERT INTO TEC_CLIENT VALUES (5, 'Prescott', 'Melisent', 'F', 43, 91, 'Thackeray', 1222, 'Yamazakichō-nakabirose', 'Japan');
INSERT INTO TEC_CLIENT VALUES (6, 'Byforth', 'Thain', 'M', 940, 11, 'Kim', 1222, 'Mulatupo', 'Panama');
INSERT INTO TEC_CLIENT VALUES (7, 'Bestwick', 'Nessy', 'F', 739, 89, 'Jackson', 1222, 'Rancho Viejo', 'Mexico');
INSERT INTO TEC_CLIENT VALUES (8, 'Collcott', 'Alphonse', 'M', 875, 93, 'Russell', 1222, 'Oyabe', 'Japan');
INSERT INTO TEC_CLIENT VALUES (9, 'Tales', 'Alexio', 'M', 170, 72, 'Farragut', 1222, 'Gaocun', 'China');
INSERT INTO TEC_CLIENT VALUES (10, 'Richin', 'Amery', 'M', 782, 70, 'Monument', 1222, 'Ishiki', 'Japan');
INSERT INTO TEC_CLIENT VALUES (11, 'Keetley', 'Sunny', 'F', 514, 24, 'Stoughton', 1222, 'Tymoshivka', 'Ukraine');
INSERT INTO TEC_CLIENT VALUES (12, 'Servis', 'Padraig', 'M', 535, 17, 'Loomis', 4682, 'Jirkov', 'Czech Republic');
INSERT INTO TEC_CLIENT VALUES (13, 'Dinning', 'Ximenez', 'M', 189, 76, 'Quincy', 1228, 'Xundian', 'China');
INSERT INTO TEC_CLIENT VALUES (14, 'Cason', 'Alasteir', 'M', 316, 9, 'Weeping Birch', 1228, 'Colmar', 'France');
INSERT INTO TEC_CLIENT VALUES (15, 'Hardson', 'Cosetta', 'F', 954, 75, 'Erie', 1228, 'Wintzenheim', 'France');
INSERT INTO TEC_CLIENT VALUES (16, 'Camilletti', 'Clarita', 'F', 42, 57, 'Brentwood', 1228, 'Solingen', 'Germany');
INSERT INTO TEC_CLIENT VALUES (17, 'Cappineer', 'Aldin', 'M', 22, 29, 'Boyd', 1228, 'Kedrovyy', 'Russia');
INSERT INTO TEC_CLIENT VALUES (18, 'Keningham', 'Moss', 'M', 427, 78, 'Morrow', 1228, 'Puračić', 'Bosnia and Herzegovina');
INSERT INTO TEC_CLIENT VALUES (19, 'Crossfield', 'Sarine', 'F', 533, 59, 'Morningstar', 1228, 'Pámfylla', 'Greece');
INSERT INTO TEC_CLIENT VALUES (20, 'Huckle', 'Ivy', 'F', 754, 60, 'Schmedeman', 1228, 'General Enrique Godoy', 'Argentina');
INSERT INTO TEC_CLIENT VALUES (21, 'Riguard', 'Rosamund', 'F', 758, 41, 'Doe Crossing', 1228, 'Wañgan', 'Philippines');
INSERT INTO TEC_CLIENT VALUES (22, 'Todhunter', 'Evelina', 'F', 649, 16, 'Boyd', 1228, 'Baihe', 'China');
INSERT INTO TEC_CLIENT VALUES (23, 'Simmen', 'Burty', 'M', 688, 38, 'Bunting', 1228, 'Niandui', 'China');
INSERT INTO TEC_CLIENT VALUES (24, 'Herrieven', 'Rebecka', 'F', 659, 15, 'Mcguire', 1228, 'Baltimore', 'United States');
INSERT INTO TEC_CLIENT VALUES (25, 'Cowl', 'Brook', 'M', 265, 57, 'Weeping Birch', 1228, 'Limatambo', 'Peru');
INSERT INTO TEC_CLIENT VALUES (26, 'Plaster', 'Meridith', 'F', 158, 34, 'Warrior', 1212, 'Nové Sedlo', 'Czech Republic');
INSERT INTO TEC_CLIENT VALUES (27, 'Healks', 'Delly', 'F', 710, 52, 'Sundown', 1212, 'Serang', 'Indonesia');
INSERT INTO TEC_CLIENT VALUES (28, 'Tooher', 'Jonell', 'F', 42, 26, 'Lerdahl', 1212, 'Santa Maria', 'Mexico');
INSERT INTO TEC_CLIENT VALUES (29, 'Edds', 'Chauncey', 'M', 717, 27, 'Merrick', 1212, 'Banjar Pekandelan', 'Indonesia');
INSERT INTO TEC_CLIENT VALUES (30, 'Borley', 'Raddie', 'M', 756, 94, 'Village', 7423, 'Carson City', 'United States');
INSERT INTO TEC_CLIENT VALUES (31, 'Castledine', 'Vasilis', 'M', 608, 97, 'New Castle', 7423, 'Hołoby', 'Ukraine');
INSERT INTO TEC_CLIENT VALUES (32, 'Gingles', 'Mufinella', 'F', 422, 43, 'Nevada', 7423, 'Masma', 'Peru');
INSERT INTO TEC_CLIENT VALUES (33, 'McTiernan', 'Mattias', 'M', 274, 51, 'Oxford', 7423, 'Coolock', 'Ireland');
INSERT INTO TEC_CLIENT VALUES (34, 'Conroy', 'Niko', 'M', 182, 2, 'Vera', 7423, 'Drien Rampak', 'Indonesia');
INSERT INTO TEC_CLIENT VALUES (35, 'Claque', 'Darrick', 'M', 638, 39, 'Londonderry', 7423, 'Amos', 'Canada');
INSERT INTO TEC_CLIENT VALUES (36, 'Stuckford', 'Otes', 'M', 539, 32, 'Shoshone', 33130, 'Borås', 'Sweden');
INSERT INTO TEC_CLIENT VALUES (37, 'Pontain', 'Cliff', 'M', 23, 88, 'Beilfuss', 33130, 'El Calvario', 'Mexico');
INSERT INTO TEC_CLIENT VALUES (38, 'Revans', 'Ahmad', 'M', 401, 90, 'Sommers', 33130, 'Lianglin', 'China');
INSERT INTO TEC_CLIENT VALUES (39, 'Fellibrand', 'Hettie', 'F', 456, 77, 'Arizona', 33130, 'Bistrica pri Tržiču', 'Slovenia');
INSERT INTO TEC_CLIENT VALUES (40, 'Branche', 'Giacobo', 'M', 382, 83, 'Columbus', 21332, 'Ia Kha', 'Vietnam');
INSERT INTO TEC_CLIENT VALUES (41, 'Boolsen', 'Jamison', 'M', 446, 80, 'Brickson Park', 21332, 'Zhentou', 'China');
INSERT INTO TEC_CLIENT VALUES (42, 'Nutten', 'Newton', 'M', 942, 10, 'Grim', 21332, 'Huanipaca', 'Peru');
INSERT INTO TEC_CLIENT VALUES (43, 'Adam', 'Budd', 'M', 475, 19, 'Meadow Ridge', 21332, 'Ribeirão Pires', 'Brazil');
INSERT INTO TEC_CLIENT VALUES (44, 'Adriaan', 'Lyndsay', 'F', 45, 24, 'Helena', 21332, 'Barengkok Hilir', 'Indonesia');
INSERT INTO TEC_CLIENT VALUES (45, 'de Keyser', 'Doyle', 'M', 84, 39, 'Anniversary', 21332, 'Dadian', 'China');
INSERT INTO TEC_CLIENT VALUES (46, 'Empleton', 'Dona', 'F', 551, 63, 'Southridge', 21332, 'Hufeng', 'China');
INSERT INTO TEC_CLIENT VALUES (47, 'Molyneux', 'Paulie', 'M', 506, 36, 'Eagan', 21332, 'Suci Kaler', 'Indonesia');
INSERT INTO TEC_CLIENT VALUES (48, 'Hartropp', 'Andrew', 'M', 758, 34, 'Hollow Ridge', 21332, 'Labin', 'Croatia');
INSERT INTO TEC_CLIENT VALUES (49, 'Gingedale', 'Malissa', 'F', 256, 45, 'Stang', 21332, 'Corrientes', 'Argentina');
INSERT INTO TEC_CLIENT VALUES (50, 'Learmount', 'Marylee', 'F', 599, 39, 'Morrow', 21332, 'Velikiy Novgorod', 'Russia');
COMMIT;

-- ====================================================
-- Insertion des commandes
-- ====================================================

INSERT INTO TEC_COMMANDE_CLI VALUES (1, '23/08/2021', 2, 8);
INSERT INTO TEC_COMMANDE_CLI VALUES (2, '07/05/2021', 28, 8);
INSERT INTO TEC_COMMANDE_CLI VALUES (3, '13/09/2021', 23, 8);
INSERT INTO TEC_COMMANDE_CLI VALUES (4, '23/07/2021', 22, 20);
INSERT INTO TEC_COMMANDE_CLI VALUES (5, '15/01/2022', 19, 3);
INSERT INTO TEC_COMMANDE_CLI VALUES (6, '19/03/2022', 38, 5);
INSERT INTO TEC_COMMANDE_CLI VALUES (7, '25/06/2021', 31, 11);
INSERT INTO TEC_COMMANDE_CLI VALUES (8, '23/01/2022', 39, 3);
INSERT INTO TEC_COMMANDE_CLI VALUES (9, '21/09/2021', 33, 1);
INSERT INTO TEC_COMMANDE_CLI VALUES (10, '02/03/2022', 28, 13);
INSERT INTO TEC_COMMANDE_CLI VALUES (11, '15/12/2021', 48, 5);
INSERT INTO TEC_COMMANDE_CLI VALUES (12, '18/04/2022', 33, 10);
INSERT INTO TEC_COMMANDE_CLI VALUES (13, '05/01/2022', 11, 12);
INSERT INTO TEC_COMMANDE_CLI VALUES (14, '07/03/2022', 37, 4);
INSERT INTO TEC_COMMANDE_CLI VALUES (15, '28/06/2021', 49, 1);
INSERT INTO TEC_COMMANDE_CLI VALUES (16, '10/12/2021', 9, 18);
INSERT INTO TEC_COMMANDE_CLI VALUES (17, '28/04/2021', 47, 17);
INSERT INTO TEC_COMMANDE_CLI VALUES (18, '02/04/2022', 21, 9);
INSERT INTO TEC_COMMANDE_CLI VALUES (19, '01/10/2021', 5, 18);
INSERT INTO TEC_COMMANDE_CLI VALUES (20, '30/05/2021', 14, 6);
INSERT INTO TEC_COMMANDE_CLI VALUES (21, '22/09/2021', 31, 18);
INSERT INTO TEC_COMMANDE_CLI VALUES (22, '12/06/2021', 10, 15);
INSERT INTO TEC_COMMANDE_CLI VALUES (23, '21/04/2022', 4, 3);
INSERT INTO TEC_COMMANDE_CLI VALUES (24, '10/09/2021', 8, 10);
INSERT INTO TEC_COMMANDE_CLI VALUES (25, '03/10/2021', 30, 19);
INSERT INTO TEC_COMMANDE_CLI VALUES (26, '27/09/2021', 13, 4);
INSERT INTO TEC_COMMANDE_CLI VALUES (27, '15/09/2021', 28, 2);
INSERT INTO TEC_COMMANDE_CLI VALUES (28, '19/10/2021', 23, 10);
INSERT INTO TEC_COMMANDE_CLI VALUES (29, '15/08/2021', 2, 17);
INSERT INTO TEC_COMMANDE_CLI VALUES (30, '01/08/2021', 41, 20);
INSERT INTO TEC_COMMANDE_CLI VALUES (31, '04/11/2021', 42, 19);
INSERT INTO TEC_COMMANDE_CLI VALUES (32, '12/02/2022', 48, 5);
INSERT INTO TEC_COMMANDE_CLI VALUES (33, '01/05/2021', 23, 20);
INSERT INTO TEC_COMMANDE_CLI VALUES (34, '11/06/2021', 12, 8);
INSERT INTO TEC_COMMANDE_CLI VALUES (35, '21/12/2021', 12, 11);
INSERT INTO TEC_COMMANDE_CLI VALUES (36, '24/03/2022', 25, 18);
INSERT INTO TEC_COMMANDE_CLI VALUES (37, '19/08/2021', 44, 1);
INSERT INTO TEC_COMMANDE_CLI VALUES (38, '23/06/2021', 7, 5);
INSERT INTO TEC_COMMANDE_CLI VALUES (39, '27/05/2021', 28, 8);
INSERT INTO TEC_COMMANDE_CLI VALUES (40, '03/01/2022', 4, 3);
INSERT INTO TEC_COMMANDE_CLI VALUES (41, '28/06/2021', 23, 10);
INSERT INTO TEC_COMMANDE_CLI VALUES (42, '04/10/2021', 4, 19);
INSERT INTO TEC_COMMANDE_CLI VALUES (43, '26/08/2021', 21, 4);
INSERT INTO TEC_COMMANDE_CLI VALUES (44, '12/09/2021', 45, 16);
INSERT INTO TEC_COMMANDE_CLI VALUES (45, '13/10/2021', 19, 5);
INSERT INTO TEC_COMMANDE_CLI VALUES (46, '30/08/2021', 42, 3);
INSERT INTO TEC_COMMANDE_CLI VALUES (47, '03/04/2022', 7, 2);
INSERT INTO TEC_COMMANDE_CLI VALUES (48, '29/04/2021', 24, 5);
INSERT INTO TEC_COMMANDE_CLI VALUES (49, '14/06/2021', 19, 16);
INSERT INTO TEC_COMMANDE_CLI VALUES (50, '07/05/2021', 6, 15);
INSERT INTO TEC_COMMANDE_CLI VALUES (51, '02/05/2021', 23, 2);
INSERT INTO TEC_COMMANDE_CLI VALUES (52, '07/04/2022', 37, 17);
INSERT INTO TEC_COMMANDE_CLI VALUES (53, '10/10/2021', 29, 17);
INSERT INTO TEC_COMMANDE_CLI VALUES (54, '01/05/2021', 3, 18);
INSERT INTO TEC_COMMANDE_CLI VALUES (55, '09/09/2021', 27, 15);
INSERT INTO TEC_COMMANDE_CLI VALUES (56, '23/09/2021', 28, 13);
INSERT INTO TEC_COMMANDE_CLI VALUES (57, '24/03/2022', 25, 15);
INSERT INTO TEC_COMMANDE_CLI VALUES (58, '21/12/2021', 12, 15);
INSERT INTO TEC_COMMANDE_CLI VALUES (59, '10/07/2021', 14, 5);
INSERT INTO TEC_COMMANDE_CLI VALUES (60, '18/09/2021', 46, 17);

-- ====================================================
-- Insertion des lignes de commandes
-- ====================================================

-- La colonne lig_prix contient des prix d'exemple
-- Dans la version qui n'est pas de test,
-- ces derniers feront références au prix des produits

INSERT INTO TEC_LIGNE_COM_CLI VALUES (1, 7, 5, 185.58);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (2, 19, 7, 219.9);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (3, 14, 5, 29.53);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (4, 19, 4, 512.89);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (5, 14, 11, 1427.48);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (6, 16, 8, 1341.91);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (7, 26, 3, 1215.83);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (8, 8, 2, 66.68);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (9, 28, 7, 599.09);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (10, 16, 7, 592.35);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (11, 17, 5, 593.79);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (12, 6, 3, 1152.64);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (13, 15, 11, 598.07);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (14, 10, 8, 474.45);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (15, 31, 3, 685.64);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (16, 30, 15, 874.19);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (17, 3, 11, 1206.77);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (18, 19, 7, 757.12);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (19, 5, 11, 72.53);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (20, 21, 9, 1497.07);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (21, 9, 3, 146.47);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (22, 2, 2, 1453.21);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (23, 6, 12, 833.44);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (24, 22, 5, 1073.87);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (25, 5, 9, 414.67);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (26, 18, 2, 780.24);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (27, 22, 10, 515.2);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (28, 32, 1, 95.77);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (29, 5, 4, 1151.29);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (30, 31, 1, 541.54);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (31, 15, 8, 1353.41);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (32, 17, 11, 205.98);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (33, 12, 6, 399.64);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (34, 23, 4, 564.11);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (35, 32, 9, 265.68);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (36, 3, 13, 528.14);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (37, 16, 3, 295.77);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (38, 11, 3, 759.98);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (39, 27, 12, 1416.77);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (40, 6, 14, 934.29);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (41, 6, 14, 1412.82);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (42, 29, 14, 1009.07);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (43, 20, 4, 681.3);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (44, 25, 10, 246.96);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (45, 28, 1, 461.1);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (46, 22, 9, 1075.7);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (47, 8, 10, 296.29);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (48, 20, 4, 1415.68);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (49, 24, 15, 135.54);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (50, 25, 1, 536.38);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (51, 14, 3, 1079.05);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (52, 1, 4, 1286.9);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (53, 25, 3, 1268.87);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (54, 6, 3, 274.63);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (55, 33, 12, 1493.4);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (56, 20, 8, 1015.49);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (57, 3, 1, 110.52);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (58, 24, 15, 422.98);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (59, 2, 4, 308.99);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (60, 19, 14, 455.02);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (16, 28, 3, 522.89);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (32, 2, 1, 352.12);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (21, 12, 11, 152.78);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (34, 27, 15, 1282.29);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (42, 33, 2, 535.2);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (8, 13, 1, 36.1);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (15, 27, 3, 1428.07);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (50, 18, 7, 692.98);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (27, 21, 11, 1089.95);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (56, 23, 1, 887.11);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (39, 21, 13, 1253.51);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (32, 12, 7, 744.5);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (1, 30, 11, 1417.39);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (20, 28, 12, 1093.78);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (29, 27, 15, 931.94);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (28, 33, 14, 618.98);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (22, 26, 5, 103.14);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (35, 13, 4, 230.66);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (5, 3, 15, 776.26);
INSERT INTO TEC_LIGNE_COM_CLI VALUES (41, 3, 3, 165.06);


-- ====================================================
-- Insertion des bons
-- ====================================================

INSERT INTO TEC_BON VALUES (1, 0.2, 21, 2);
INSERT INTO TEC_BON VALUES (2, 0.86, 22, 34);
INSERT INTO TEC_BON VALUES (3, 0.34, 7, 13);
INSERT INTO TEC_BON VALUES (4, 0.58, 10, 51);
INSERT INTO TEC_BON VALUES (5, 0.74, 50, 37);
INSERT INTO TEC_BON VALUES (6, 0.47, 1, 58);
INSERT INTO TEC_BON VALUES (7, 0.9, 8, 42);
INSERT INTO TEC_BON VALUES (8, 0.78, 13, 23);
INSERT INTO TEC_BON VALUES (9, 0.12, 22, 20);
INSERT INTO TEC_BON VALUES (10, 0.55, 49, 14);


-- ====================================================
-- Insertion des commandes fournisseurs
-- ====================================================

INSERT INTO TEC_COMMANDE_FOU VALUES (1, '08/05/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (2, '07/11/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (3, '18/09/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (4, '26/11/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (5, '15/06/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (6, '07/05/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (7, '20/04/2022');
INSERT INTO TEC_COMMANDE_FOU VALUES (8, '29/04/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (9, '17/01/2022');
INSERT INTO TEC_COMMANDE_FOU VALUES (10, '20/05/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (11, '07/11/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (12, '21/12/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (13, '28/04/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (14, '01/02/2022');
INSERT INTO TEC_COMMANDE_FOU VALUES (15, '03/01/2022');
INSERT INTO TEC_COMMANDE_FOU VALUES (16, '29/05/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (17, '01/03/2022');
INSERT INTO TEC_COMMANDE_FOU VALUES (18, '05/10/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (19, '23/08/2021');
INSERT INTO TEC_COMMANDE_FOU VALUES (20, '24/06/2021');


-- ====================================================
-- Insertion des lignes de commandes fournisseurs
-- ====================================================

INSERT INTO TEC_LIGNE_COM_FOU VALUES (1, 7, 14, 3527);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (2, 7, 25, 3164);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (3, 24, 28, 4984);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (4, 8, 24, 684);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (5, 15, 17, 3551);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (6, 30, 8, 1859);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (7, 25, 23, 974);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (8, 4, 13, 3807);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (9, 10, 3, 4016);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (10, 15, 10, 1118);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (11, 7, 13, 1734);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (12, 10, 13, 3020);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (13, 33, 12, 1224);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (14, 28, 6, 692);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (15, 5, 15, 3693);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (16, 33, 29, 3433);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (17, 31, 28, 4675);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (18, 1, 15, 1850);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (19, 29, 2, 2676);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (20, 33, 6, 1326);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (6, 14, 20, 2759);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (17, 25, 20, 4408);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (20, 24, 21, 3950);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (18, 3, 11, 673);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (1, 1, 18, 2652);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (20, 9, 17, 453);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (6, 17, 6, 2441);
INSERT INTO TEC_LIGNE_COM_FOU VALUES (3, 20, 21, 694);
COMMIT;
