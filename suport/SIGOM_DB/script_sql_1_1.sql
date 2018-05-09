-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.

CREATE TABLE Carro (
codCarro INTEGER PRIMARY KEY,
codCli INTEGER,
marca VARCHAR(20),
modelo VARCHAR(20),
cor VARCHAR(10),
placa VARCHAR(10)
)

CREATE TABLE Servico (
codServ VARCHAR(2) PRIMARY KEY,
preco FLOAT,
Tipo VARCHAR(20)
)

CREATE TABLE OrdemServico (
numOs INTEGER PRIMARY KEY,
matricFunc INTEGER,
codCli INTEGER,
codCarro INTEGER,
codServ VARCHAR(2),
descricao VARCHAR(100),
Status VARCHAR(20),
FOREIGN KEY(codCarro) REFERENCES Carro (codCarro),
FOREIGN KEY(codServ) REFERENCES Servico (codServ)
)

CREATE TABLE Cliente (
codCli INTEGER PRIMARY KEY,
nomeCli VARCHAR(50),
rgCli INTEGER,
cpfCli INTEGER,
telefoneCli VARCHAR(15),
emailCli VARCHAR(50)
)

CREATE TABLE Funcionario (
matricFunc INTEGER PRIMARY KEY,
nomeFunc VARCHAR(50),
rgFunc INTEGER,
cpfFunc INTEGER,
telefoneFunc VARCHAR(15),
emailFunc VARCHAR(50),
formacao VARCHAR(30),
funcao VARCHAR(30)
)

ALTER TABLE Carro ADD FOREIGN KEY(codCli) REFERENCES Cliente (codCli)
ALTER TABLE OrdemServico ADD FOREIGN KEY(matricFunc) REFERENCES Funcionario (matricFunc)
ALTER TABLE OrdemServico ADD FOREIGN KEY(codCli) REFERENCES Cliente (codCli)
