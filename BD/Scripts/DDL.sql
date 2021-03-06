CREATE DATABASE CZBooks_;

USE CZBooks_;

CREATE TABLE TiposUsuarios
(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(200)NOT NULL
);
GO

CREATE TABLE Usuarios
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuarios (IdTipoUsuario),
	Email VARCHAR(200)NOT NULL,
	Senha	VARCHAR(200)NOT NULL,
	Nome VARCHAR(200)NOT NULL
);
GO

CREATE TABLE Autores
(
	IdAutor INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuarios (IdUsuario),
	Nome VARCHAR(200)NOT NULL
);
GO

CREATE TABLE Livrarias
(
	IdLivraria INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(200)NOT NULL,
	Endereco VARCHAR(200)NOT NULL
);
GO

CREATE TABLE Categorias
(
	IdCategoria INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(200)NOT NULL
);
GO

CREATE TABLE Livros
(
	IdLivro INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuarios (IdUsuario),
	IdAutor INT FOREIGN KEY REFERENCES Autores (IdAutor),
	IdCategoria	INT FOREIGN KEY REFERENCES Categorias (IdCategoria),
	IdLivraria	INT FOREIGN KEY REFERENCES Livrarias (IdLivraria),
	Titulo VARCHAR(500) NOT NULL,
	Sinopse VARCHAR(500)NOT NULL,
	DataPublicacao DATE NOT NULL,
	Preco VARCHAR(500) NOT NULL
);
GO