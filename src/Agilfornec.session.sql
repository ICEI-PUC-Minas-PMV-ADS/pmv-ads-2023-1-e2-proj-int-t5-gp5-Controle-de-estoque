CREATE TABLE Usuario (
  Id INT NOT NULL AUTO_INCREMENT,
  Username VARCHAR(50) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  Filial_trabalhada VARCHAR(50) NOT NULL,
  PRIMARY KEY (Id)
);
INSERT INTO Usuario (Username, Password, Filial_trabalhada)
VALUES ('Raniel.Araujo', '0701', 'Matriz');
SELECT *
FROM Usuario;