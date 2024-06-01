CREATE DATABASE MediaTek86;

CREATE USER 'mediatek_user'@'localhost' IDENTIFIED BY 'password123';
GRANT ALL PRIVILEGES ON MediaTek86.* TO 'mediatek_user'@'localhost';
FLUSH PRIVILEGES;

USE MediaTek86;

CREATE TABLE responsable (
    login VARCHAR(64),
    pwd VARCHAR(64)
);

CREATE TABLE service (
    idservice INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(100) NOT NULL
);

CREATE TABLE motif (
    idmotif INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(100) NOT NULL
);

CREATE TABLE personnel (
    idpersonnel INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(100) NOT NULL,
    prenom VARCHAR(100) NOT NULL,
    tel VARCHAR(15),
    mail VARCHAR(100),
    idservice INT,
    FOREIGN KEY (idservice) REFERENCES service(idservice)
);

CREATE TABLE absence (
    idabsence INT AUTO_INCREMENT PRIMARY KEY,
    idpersonnel INT,
    datedebut DATE NOT NULL,
    datefin DATE NOT NULL,
    idmotif INT,
    FOREIGN KEY (idpersonnel) REFERENCES personnel(idpersonnel),
    FOREIGN KEY (idmotif) REFERENCES motif(idmotif)
);

INSERT INTO responsable (login, pwd) VALUES ('admin', SHA2('adminpassword', 256));

INSERT INTO motif (libelle) VALUES ('vacances'), ('maladie'), ('motif familial'), ('congé parental');

INSERT INTO service (nom) VALUES ('administratif'), ('médiation culturelle'), ('prêt');

INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES
('Dupont', 'Jean', '0601020304', 'jean.dupont@example.com', 1),
('Martin', 'Marie', '0605060708', 'marie.martin@example.com', 2),
('Durand', 'Luc', '0610111213', 'luc.durand@example.com', 3),
('Leroy', 'Anne', '0614151617', 'anne.leroy@example.com', 1),
('Moreau', 'Paul', '0618192021', 'paul.moreau@example.com', 2),
('Simon', 'Julie', '0622232425', 'julie.simon@example.com', 3),
('Michel', 'Pierre', '0626272829', 'pierre.michel@example.com', 1),
('Garcia', 'Laura', '0630313233', 'laura.garcia@example.com', 2),
('Bernard', 'Nicolas', '0634353637', 'nicolas.bernard@example.com', 3),
('Petit', 'Sophie', '0638394041', 'sophie.petit@example.com', 1);

INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(1, '2024-01-01', '2024-01-10', 1),
(2, '2024-02-15', '2024-02-20', 2),
(3, '2024-03-05', '2024-03-12', 3),
(4, '2024-04-10', '2024-04-15', 4),
(5, '2024-05-01', '2024-05-05', 1),
(6, '2024-06-07', '2024-06-14', 2),
(7, '2024-07-18', '2024-07-25', 3),
(8, '2024-08-20', '2024-08-27', 4),
(9, '2024-09-01', '2024-09-08', 1),
(10, '2024-10-10', '2024-10-17', 2),
(1, '2024-11-01', '2024-11-05', 3),
(2, '2024-12-15', '2024-12-20', 4),
(3, '2024-11-07', '2024-11-14', 1),
(4, '2024-12-20', '2024-12-27', 2),
(5, '2024-11-15', '2024-11-20', 3),
(6, '2024-12-07', '2024-12-14', 4),
(7, '2024-11-18', '2024-11-25', 1),
(8, '2024-12-20', '2024-12-27', 2),
(9, '2024-11-01', '2024-11-08', 3),
(10, '2024-12-10', '2024-12-17', 4),
(1, '2024-01-11', '2024-01-20', 1),
(2, '2024-02-21', '2024-02-25', 2),
(3, '2024-03-13', '2024-03-20', 3),
(4, '2024-04-16', '2024-04-22', 4),
(5, '2024-05-06', '2024-05-10', 1),
(6, '2024-06-15', '2024-06-22', 2),
(7, '2024-07-26', '2024-08-02', 3),
(8, '2024-08-28', '2024-09-04', 4),
(9, '2024-09-09', '2024-09-16', 1),
(10, '2024-10-18', '2024-10-25', 2),
(1, '2024-11-06', '2024-11-11', 3),
(2, '2024-12-21', '2024-12-26', 4),
(3, '2024-11-15', '2024-11-21', 1),
(4, '2024-12-28', '2024-01-04', 2),
(5, '2024-11-21', '2024-11-26', 3),
(6, '2024-12-15', '2024-12-21', 4),
(7, '2024-11-26', '2024-12-02', 1),
(8, '2024-12-28', '2024-01-03', 2),
(9, '2024-11-09', '2024-11-16', 3),
(10, '2024-12-18', '2024-12-24', 4),
(1, '2024-01-21', '2024-01-30', 1),
(2, '2024-02-26', '2024-03-02', 2),
(3, '2024-03-21', '2024-03-28', 3),
(4, '2024-04-23', '2024-04-30', 4),
(5, '2024-05-11', '2024-05-16', 1),
(6, '2024-06-23', '2024-06-29', 2),
(7, '2024-08-03', '2024-08-09', 3),
(8, '2024-09-05', '2024-09-11', 4),
(9, '2024-09-17', '2024-09-23', 1),
(10, '2024-10-26', '2024-11-02', 2);
