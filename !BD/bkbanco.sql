CREATE DATABASE ProdPacote;
USE ProdPacote;

CREATE TABLE Produto(
ID_Produto INT PRIMARY KEY AUTO_INCREMENT,
Nome VARCHAR (200) NOT NULL,
Descricao VARCHAR (200) NOT NULL,
Preco DOUBLE NOT NULL,
`status` CHAR (10) NOT NULL);  

CREATE TABLE Pacote(
ID_Pacote INT PRIMARY KEY AUTO_INCREMENT,
Nome VARCHAR (200) NOT NULL,
peca VARCHAR (200) NOT NULL,
FK_ID_Produto int NOT NULL,
Quantidade INT NOT NULL,
Preco_data DOUBLE,
Data_entrada DATE NOT NULL,
Data_saida DATE,
Total DOUBLE,
CONSTRAINT fk1
FOREIGN KEY (FK_ID_Produto)
REFERENCES Produto(ID_Produto));



    
   
   
   
   
   
   
   
   
   
   
   
   
   