CREATE DATABASE imperiohotel;
USE imperiohotel;

CREATE TABLE Clientes (
    idCliente INTEGER PRIMARY KEY auto_increment,
    nome VARCHAR(30),
    cpf VARCHAR(15),
    email VARCHAR(30)
);

CREATE TABLE ContatoReclamacao  (
    idContato INTEGER PRIMARY KEY auto_increment,
    email VARCHAR(30),
    nome VARCHAR(30),
    assunto VARCHAR(20)
);

CREATE TABLE Passagem (
    idPassagem INTEGER PRIMARY KEY auto_increment,
    nome_passageiro VARCHAR(30),
    data_ida DATE,
    id_usuario INTEGER,
    FOREIGN KEY (id_usuario) references Usuario (id_usuario),
    id_destino INTEGER,
    FOREIGN KEY (id_destino) references Destinos (id_destino)
);

CREATE TABLE Promocoes (
    id_compra INTEGER PRIMARY KEY auto_increment,
    valor_compra DECIMAL,
    data_compra DATE,
    id_usuario INTEGER,
    FOREIGN KEY (id_usuario) references Usuario (id_usuario),
    id_passagem INTEGER,
    FOREIGN KEY (id_passagem) references Passagem (id_passagem)
);






